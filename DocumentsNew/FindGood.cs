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
    }
}
