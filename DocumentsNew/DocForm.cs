using System;
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
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablePartGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int colIndex = TablePartGrid.CurrentCell.ColumnIndex;
            if (colIndex == TablePartGrid.Columns["GoodName"].Index)
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    addItems(DataCollection);
                    autoText.AutoCompleteCustomSource = DataCollection;
                }
            }
        }

        private void addItems(AutoCompleteStringCollection col)
        {
            using (DocContext db = new DocContext())
            {
                foreach (Good g in db.Goods) col.Add(g.GoodName);
            }
            
        }

        private void TablePartGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (TablePartGrid.Rows.Count > 0 && TablePartGrid.Columns.Count >0)
            {
                if (e.ColumnIndex == GoodName.Index)
                {
                    using (DocContext db = new DocContext())
                    {
                        string goodname = TablePartGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                        Good good = db.Goods.FirstOrDefault(Good => Good.GoodName == goodname);
                        if (good != null)
                        {
                            TablePartGrid[GoodId.Index, e.RowIndex].Value = good.Id.ToString();

                            if (db.GoodBalnces.Where(b => b.GoodId == good.Id).Count() >0)
                            {
                                DateTime lastRegDate = db.GoodBalnces.Where(b => b.GoodId == good.Id).Max(b => b.DateTime);
                                if (lastRegDate != null)
                                {
                                    var Regs = db.GoodBalnces.Where(b => b.GoodId == good.Id).ToList();
                                    if (Regs.Count > 0)
                                    {
                                        //получить остаток
                                        GoodBalnce reg = Regs.Find(r => r.DateTime == lastRegDate);
                                        TablePartGrid[Balance.Index, e.RowIndex].Value = reg.Balance;
                                    }
                                    else
                                    {
                                        //обработать
                                    }
                                }
                                else
                                {
                                    TablePartGrid[Balance.Index, e.RowIndex].Value = "0";
                                }
                            }
                            else
                            {
                                TablePartGrid[Balance.Index, e.RowIndex].Value = "0";
                            }

                            

                        }
                        else
                        {
                            MessageBox.Show("Комплектующая не существует!");
                        }
                    }

                }
                if (e.ColumnIndex == quantity.Index)
                {
                    if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Списание" && int.Parse(TablePartGrid[Balance.Index, e.RowIndex].Value.ToString()) < int.Parse(TablePartGrid[quantity.Index, e.RowIndex].Value.ToString()) )
                    {
                        TablePartGrid[quantity.Index, e.RowIndex].Value = TablePartGrid[Balance.Index, e.RowIndex].Value.ToString();
                        MessageBox.Show("Не достаточно остатков!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStringToTablePart();
        }

        private void AddStringToTablePart()
        {
                TablePartGrid.Rows.Add();
        }

        private void RemoveStringFromTAblePart()
        {

            if (TablePartGrid.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                if (TablePartGrid.SelectedRows.Count > 0)
                {   
                    //обработать удаление выделенных строк(1 или больше)
                    List<DataGridViewRow> rows4remove = new List<DataGridViewRow>();
                    try
                    {
                        foreach (DataGridViewRow selectedRow in TablePartGrid.SelectedRows)
                        {
                            rows4remove.Add(selectedRow);
                        }
                        foreach (DataGridViewRow row4remove in rows4remove)
                        {
                            TablePartGrid.Rows.Remove(row4remove);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при удалении выделынных строк");
                    }
                    
                }
                else
                {
                    //обработать удаление строк с выделенными ячейками
                    try
                    {
                        List<DataGridViewRow> rows4remove = new List<DataGridViewRow>();
                        int selectedCellsCount = TablePartGrid.GetCellCount(DataGridViewElementStates.Selected);
                        for (int i = 0; i < selectedCellsCount; i++)
                        {
                            int rowIndex = TablePartGrid.SelectedCells[i].RowIndex;
                            DataGridViewRow row4remove = TablePartGrid.Rows[rowIndex];
                            if (!rows4remove.Contains(row4remove))
                                rows4remove.Add(row4remove);
                        }
                        foreach (DataGridViewRow row4remove in rows4remove)
                        {
                            TablePartGrid.Rows.Remove(row4remove);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при удалении выделынных строк");
                    }
                    
                }
            }
            
        }

        private void TablePartGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FillSerials();
        }

        private void FillSerials()
        {
            foreach (DataGridViewRow row in TablePartGrid.Rows)
            {
                row.Cells[Serial.Index].Value = (row.Index + 1).ToString();
            }
        }

        private void RowDeleteButton_Click(object sender, EventArgs e)
        {
            RemoveStringFromTAblePart();
        }

        private void TablePartGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            FillSerials();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (DocIsCorrect())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private bool DocIsCorrect()
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Не заполнен тип документа!");
                return false;
            }
            foreach (DataGridViewRow row in TablePartGrid.Rows)
            {
                if(row.Cells[GoodName.Index].Value == null)
                {
                    MessageBox.Show("Введите имя комплектующей в " + row.Cells[Serial.Index].Value.ToString() + " строке");
                    TablePartGrid.ClearSelection();
                    TablePartGrid[GoodName.Index, row.Index].Selected = true;
                    return false;
                }
                if (row.Cells[quantity.Index].Value == null || Int32.Parse(row.Cells[quantity.Index].Value.ToString()) < 1)
                {
                    MessageBox.Show("Введите количество " + row.Cells[Serial.Index].Value.ToString() + " строке");
                    TablePartGrid.ClearSelection();
                    TablePartGrid[quantity.Index, row.Index].Selected = true;
                    return false;
                }
            }
            
            return true;
        }

        private void findGood_Click(object sender, EventArgs e)
        {
            FindGood findGood = new FindGood();
            DialogResult result = findGood.ShowDialog(this);
            if (result == DialogResult.Cancel) return;



        }
    }
}
