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
    public partial class GoodsListForm : Form

    {
        DocContext db;
        public GoodsListForm()
        {
            InitializeComponent();

            db = new DocContext();
            db.Goods.Load();
            dataGridView1.DataSource = db.Goods.Local.ToBindingList();
        }

        private void AddGood_Click(object sender, EventArgs e)
        {
            AddGood();
        }

        private void AddGood()
        {
            AddGoodForm addGoodForm = new AddGoodForm();
            
            DialogResult result = addGoodForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;

            Good good = new Good();
            good.GoodName = addGoodForm.textBox1.Text;
            //good.Balance = (int)addGoodForm.numericUpDown1.Value;

            db.Goods.Add(good);
            db.SaveChanges();
        }

        private void GoodsListForm_Load(object sender, EventArgs e)
        {
            foreach  (DataGridViewRow row in dataGridView1.Rows)
            {
                FillBalance(row);
            }
        }

        private void FillBalance(DataGridViewRow row)
        {

            //Заполняем остатки при создании формы
            int GoodId = Int32.Parse(row.Cells[idDataGridViewTextBoxColumn.Index].Value.ToString()); //получим ID комплектующей для отбора по регистру
            if (db.GoodBalnces.Where(b => b.GoodId == GoodId).Count() > 0)//проверим есть ли записи в регистре по данной комплектующей
            {
                 
                DateTime lastRegDate = db.GoodBalnces.Where(b => b.GoodId == GoodId).Max(b => b.DateTime); //получим дату последнего движения в ригистре
                if (lastRegDate != null) //если движения по регистру были, получим остоаток для комплектующей на дату последнего движения
                {
                    var Regs = db.GoodBalnces.Where(b => b.GoodId == GoodId).ToList();//формируем список со всеми движениями по комплектующей. КАК сделать отбор сразу по дате????
                    if (Regs.Count > 0)
                    {
                        //получить остаток
                        GoodBalnce reg = Regs.Find(r => r.DateTime == lastRegDate);//из полученго списка движений получаем запись с максимальной датой
                        row.Cells[Balance.Index].Value = reg.Balance.ToString();//помещаем значение остатка в ячейку Balance
                    }
                    else
                    {
                        //обработать ошибку
                    }
                }
                else
                {
                    row.Cells[Balance.Index].Value = "0"; //Если нет записий в ригистре, значит остаток = 0
                }
            }
            else
            {
                row.Cells[Balance.Index].Value = "0"; //Если нет записий в ригистре, значит остаток = 0
            }

        }

        private void dataGridView1_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        { //можно удалять
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                FillBalance(row);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                FillBalance(row);
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                FillBalance(row);
            }
        }
    }
}
