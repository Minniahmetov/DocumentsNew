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
    public partial class AddGoodForm : Form
    {
        DocContext db;
        public AddGoodForm()
        {
            InitializeComponent();
            OK.Enabled = false;
            db = new DocContext();
        }


        private void OK_Click(object sender, EventArgs e) 
        {
            //проверка уникальност наименвоания комплектующей при создании нового элемента
            Good good = new Good();
            good = db.Goods.FirstOrDefault(g => g.GoodName == textBox1.Text);
            if (good == null) this.DialogResult = DialogResult.OK;
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Ошибка при созданиии элемента. Не уникальное наименование комплектующей!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //деактивируем кнопку ок при пустом наименовании комплектующей
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                OK.Enabled = false;
            }
            else
            {
                OK.Enabled = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
