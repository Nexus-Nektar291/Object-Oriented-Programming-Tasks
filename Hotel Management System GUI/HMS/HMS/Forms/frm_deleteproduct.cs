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
    public partial class frm_deleteproduct : Form
    {
        public frm_deleteproduct()
        {
            InitializeComponent();
        }

        private void frm_deleteproduct_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = txtbox_name.Text;
            string type = txtbox_type.Text;
            bool flag = ProductDL.delete_product(name, type);
            if (flag == false)
            {
                label1.Visible = true;
            }
            else if (flag == true)
            {
                this.Hide();
                frm_adminmeu form = new frm_adminmeu();
                form.Show();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_adminmeu form = new frm_adminmeu();
            form.Show();
        }

        private void frm_deleteproduct_Load(object sender, EventArgs e)
        {

        }
    }
}
