using Gui_hotelmanagementsystem.BL;
using Gui_hotelmanagementsystem.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_hotelmanagementsystem.Forms
{
    public partial class frm_viewproducts : Form
    {
        public frm_viewproducts()
        {
            InitializeComponent();
        }
        private void lbl_signin_Click(object sender, EventArgs e) { }
        private void lbl_hotelname_Click(object sender, EventArgs e) { }
        private void Button1_Click(object sender, EventArgs e)
        {
        }
        DataTable table = new DataTable();
        private void frm_viewproducts_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Products Names", typeof(string));
            table.Columns.Add("Products Types", typeof(string));
            table.Columns.Add("Products Price", typeof(string));
            dataGridView1.DataSource = table;
            foreach (ProductBL b in ProductDL.products)
            {
                table.Rows.Add(b.getname(), b.gettype(), b.getprice());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_adminmeu form = new frm_adminmeu();
            form.Show();
        }
    }
}
