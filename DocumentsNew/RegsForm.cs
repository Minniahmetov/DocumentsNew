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
    public partial class RegsForm : Form
    {
        DocContext db;
        public RegsForm()
        {
            InitializeComponent();
            db = new DocContext();
            db.GoodBalnces.Load();
            dataGridView1.DataSource = db.GoodBalnces.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
