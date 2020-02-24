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
    public partial class FindGood : Form
    {
        DocContext db;
        public FindGood()
        {
            InitializeComponent();
            db = new DocContext();
            db.Goods.Load();
            dataGridView1.DataSource = db.Goods.Local.ToBindingList();
        }

        private void AddNewGoodButton_Click(object sender, EventArgs e)
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

            db.Goods.Add(good);
            db.SaveChanges();
        }
    }
}
