using Gui_hotelmanagementsystem.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_hotelmanagementsystem.Forms
{
    public partial class frm_updateproductprice : Form
    {
        public frm_updateproductprice()
        {
            InitializeComponent();
        }

        private void frm_updateproductprice_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = txtbox_name.Text;
            double previous_price = double.Parse(txtbox_price.Text);
            double new_price = double.Parse(txtbox_newprice.Text);
            bool flag = ProductDL.update_price(name, previous_price, new_price);
            if (flag == false)
            {
                lbl_error.Visible = true;
            }
            else if (flag)
            {
                this.Hide();
                frm_adminmeu form = new frm_adminmeu();
                form.Show();
            }
        }

        private void btn_submit_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_name.Text) || string.IsNullOrEmpty(txtbox_price.Text) || string.IsNullOrEmpty(txtbox_newprice.Text))
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
            frm_adminmeu form=new frm_adminmeu();
            form.Show();
        }
    }
}
