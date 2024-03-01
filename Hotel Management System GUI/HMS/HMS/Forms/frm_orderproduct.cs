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
    public partial class frm_orderproduct : Form
    {
        public frm_orderproduct()
        {
            InitializeComponent();
        }

        private void btn_submit_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_name.Text) || string.IsNullOrEmpty(txtbox_type.Text))
            {
                btn_submit.Cursor = Cursors.No;
            }
            else
            {
                btn_submit.Cursor = Cursors.Default;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_usermenu form = new frm_usermenu();
            form.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = txtbox_name.Text;
            string type = txtbox_type.Text;
            bool flag = ProductDL.isproductexists(name, type);
            if (flag == false)
            {
                lbl_error.Visible = true;
            }
            if (flag == true)
            {
                this.Hide();
                frm_usermenu form = new frm_usermenu();
                form.Show();
            }
        }

        private void frm_orderproduct_Load(object sender, EventArgs e)
        {

        }
    }
}
