using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DocumentsNew
{
    public partial class MainForm : Form
    {
        DocContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new DocContext();
            db.Docs.Load();
            DocListView.DataSource = db.Docs.Local.ToBindingList();
        }

        private void AddDocButton_Click(object sender, EventArgs e)
        {
            AddDoc();
        }

        private void AddDoc()
        {
            DocForm docForm = new DocForm();
            docForm.TablePartGrid.Rows.Add();
            DialogResult result = docForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;

            if (result == DialogResult.OK)
            {
                Doc doc = new Doc();
                doc.DateTime = docForm.dateTimePicker1.Value;
                doc.DocType = docForm.comboBox1.SelectedItem.ToString();
                db.Docs.Add(doc);
                db.SaveChanges();

                TablePart tablePart = new TablePart();
                tablePart.Id = doc.Id;

                foreach (DataGridViewRow row in docForm.TablePartGrid.Rows)
                {
                    TablePartString tablePartString = new TablePartString();
                    tablePartString.GoodId = Int32.Parse(row.Cells["GoodId"].Value.ToString());

                    tablePartString.Quantity = Int32.Parse(row.Cells["quantity"].Value.ToString());
                    tablePartString.Balance = Int32.Parse(row.Cells["Balance"].Value.ToString());

                    tablePart.TablePartStrings.Add(tablePartString);

                    {
                        if (db.GoodBalnces.Where(b => b.GoodId == tablePartString.GoodId).Count() > 0)
                        {
                            DateTime lastRegDate = db.GoodBalnces.Where(b => b.GoodId == tablePartString.GoodId).Max(b => b.DateTime);
                            if (lastRegDate != null)
                            {
                                //есть регистрирующая запись
                                var Regs = db.GoodBalnces.Where(b => b.GoodId == tablePartString.GoodId).ToList();
                                if (Regs.Count > 0)
                                {
                                    GoodBalnce lastReg = Regs.Find(r => r.DateTime == lastRegDate);
                                    //создать запись
                                    GoodBalnce newReg = new GoodBalnce();
                                    newReg.GoodId = tablePartString.GoodId;
                                    newReg.DocId = doc.Id;
                                    newReg.DateTime = doc.DateTime;
                                    newReg.openingBalance = tablePartString.Balance;
                                    if (doc.DocType == "Списание")
                                    {
                                        newReg.Flow = 0;
                                        newReg.Cancellaton = tablePartString.Quantity;
                                    }
                                    else
                                    {
                                        newReg.Flow = tablePartString.Quantity;
                                        newReg.Cancellaton = 0;
                                    }
                                    newReg.Balance = newReg.openingBalance - newReg.Cancellaton + newReg.Flow;

                                    db.GoodBalnces.Add(newReg);
                                    db.SaveChanges();
                                }
                                else
                                {
                                    //обработать ошибку
                                }
                            }
                            else
                            {
                                //нет регистрирующих записей
                                //создать первую регистрирующую запись
                                GoodBalnce newReg = new GoodBalnce();
                                newReg.GoodId = tablePartString.GoodId;
                                newReg.DocId = doc.Id;
                                newReg.DateTime = doc.DateTime;
                                newReg.openingBalance = 0;
                                if (doc.DocType == "Списание")
                                {
                                    newReg.Flow = 0;
                                    newReg.Cancellaton = tablePartString.Quantity;
                                }
                                else
                                {
                                    newReg.Flow = tablePartString.Quantity;
                                    newReg.Cancellaton = 0;
                                }


                                newReg.Balance = newReg.openingBalance - newReg.Cancellaton + newReg.Flow;

                                db.GoodBalnces.Add(newReg);
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            //создать первую регистрирующую запись
                            GoodBalnce newReg = new GoodBalnce();
                            newReg.GoodId = tablePartString.GoodId;
                            newReg.DocId = doc.Id;
                            newReg.DateTime = doc.DateTime;
                            newReg.openingBalance = 0;
                            if (doc.DocType == "Списание")
                            {
                                newReg.Flow = 0;
                                newReg.Cancellaton = tablePartString.Quantity;
                            }
                            else
                            {
                                newReg.Flow = tablePartString.Quantity;
                                newReg.Cancellaton = 0;
                            }


                            newReg.Balance = newReg.openingBalance - newReg.Cancellaton + newReg.Flow;

                            db.GoodBalnces.Add(newReg);
                            db.SaveChanges();
                        }

                    }

                }

                db.TableParts.Add(tablePart);
                db.SaveChanges();

                MessageBox.Show("Документ добавлен!");
            }
        }

        private void OpenDocButton_Click(object sender, EventArgs e)
        {
            OpenDoc();
        }

        private void OpenDoc()
        {
            if (DocListView.SelectedRows.Count > 0)
            {
                int index = DocListView.SelectedRows[0].Index;
                int id = 0;

                bool converted = Int32.TryParse(DocListView["Id", index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Doc doc = db.Docs.Find(id);
                TablePart tablePart = db.TableParts.Find(id);

                DocForm docForm = new DocForm();

                docForm.textBox1.Text = doc.Id.ToString();
                docForm.textBox1.ReadOnly = true;
                docForm.textBox1.Enabled = false;
                docForm.dateTimePicker1.Value = doc.DateTime;
                docForm.dateTimePicker1.Enabled = false;
                docForm.comboBox1.SelectedItem = doc.DocType;

                if (doc.DateTime >= DateTime.Today && doc.DateTime < DateTime.Today.AddDays(1))
                {
                    docForm.OkButton.Enabled = true;
                }
                else
                {
                    docForm.OkButton.Enabled = false;
                }


                foreach (TablePartString tablePartString in tablePart)
                {
                    int rowIndex = docForm.TablePartGrid.Rows.Add();


                    try
                    {
                        docForm.TablePartGrid["GoodName", rowIndex].Value = db.Goods.Find(tablePartString.GoodId).GoodName;
                    }
                    catch (Exception)
                    {
                        docForm.TablePartGrid["GoodName", rowIndex].Value = "Error";
                    }


                    try
                    {
                        docForm.TablePartGrid["quantity", rowIndex].Value = tablePartString.Quantity.ToString();
                    }
                    catch (Exception)
                    {
                        docForm.TablePartGrid["quantity", rowIndex].Value = "Error";
                    }


                    try
                    {
                        docForm.TablePartGrid["Balance", rowIndex].Value = tablePartString.Balance.ToString();
                    }
                    catch (Exception)
                    {
                        docForm.TablePartGrid["Balance", rowIndex].Value = "Error";
                    }

                }

                DialogResult result = docForm.ShowDialog(this);

                if (result == DialogResult.Cancel) return;
                //найти запись в GoodBalance и исправить
                //и не забыть дату изменить
                doc.DateTime = DateTime.Now;
                doc.DocType = docForm.comboBox1.SelectedItem.ToString();
                db.Entry(doc).State = EntityState.Modified;
                db.SaveChanges();

                Stack<int> TPS_Id4Remove = new Stack<int>();

                foreach (TablePartString TPS in tablePart)
                {
                    TPS_Id4Remove.Push(TPS.Id);
                }

                foreach (int i in TPS_Id4Remove)
                {
                    db.TPSs.Remove(db.TPSs.Find(i));
                    db.SaveChanges();
                }

                var goodBalnceList4delete = db.GoodBalnces.Where(b => b.DocId == doc.Id);

                Stack<int> regsId4Remove = new Stack<int>();
                foreach (GoodBalnce regNote in goodBalnceList4delete)
                {
                    regsId4Remove.Push(regNote.Id);
                }

                foreach (int i in regsId4Remove)
                {
                    db.GoodBalnces.Remove(db.GoodBalnces.Find(i));
                    db.SaveChanges();
                }

                tablePart.TablePartStrings.Clear();

                foreach (DataGridViewRow row in docForm.TablePartGrid.Rows)
                {
                    TablePartString tablePartString = new TablePartString();
                    tablePartString.GoodId = Int32.Parse(row.Cells["GoodId"].Value.ToString());

                    tablePartString.Quantity = Int32.Parse(row.Cells["quantity"].Value.ToString());
                    tablePartString.Balance = Int32.Parse(row.Cells["Balance"].Value.ToString());

                    tablePart.TablePartStrings.Add(tablePartString);

                    GoodBalnce newReg = new GoodBalnce();
                    newReg.GoodId = tablePartString.GoodId;
                    newReg.DocId = doc.Id;
                    newReg.DateTime = doc.DateTime;
                    newReg.openingBalance = Int32.Parse(row.Cells["Balance"].Value.ToString());
                    if (doc.DocType == "Списание")
                    {
                        newReg.Flow = 0;
                        newReg.Cancellaton = tablePartString.Quantity;
                    }
                    else
                    {
                        newReg.Flow = tablePartString.Quantity;
                        newReg.Cancellaton = 0;
                    }
                    newReg.Balance = newReg.openingBalance - newReg.Cancellaton + newReg.Flow;

                    db.GoodBalnces.Add(newReg);
                    db.SaveChanges();
                }

            }
        }

        private void DeleteDocButton_Click(object sender, EventArgs e)
        {
            DeleteDoc();
        }

        private void DeleteDoc()
        {
            if (DocListView.SelectedRows.Count > 0)
            {
                int index = DocListView.SelectedRows[0].Index;
                int id = 0;

                bool converted = Int32.TryParse(DocListView["Id", index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Doc doc = db.Docs.Find(id);
                TablePart tablePart = db.TableParts.Find(id);

                if (tablePart != null) //удалить условие?
                {
                    tablePart.TablePartStrings.Clear();
                    db.TableParts.Remove(tablePart);
                    db.SaveChanges();
                }
                
                
                db.Docs.Remove(doc);
                db.SaveChanges();
            }
        }

        private void GoodList_Click(object sender, EventArgs e)
        {
            GoodsListForm goodListForm = new GoodsListForm();
            goodListForm.Show();
        }

        private void ShowRegButton_Click(object sender, EventArgs e)
        {
            RegsForm regsForm = new RegsForm();
            DialogResult result = regsForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
