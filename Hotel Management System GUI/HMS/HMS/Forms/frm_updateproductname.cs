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
    public partial class frm_updateproductname : Form
    {
        public frm_updateproductname()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_adminmeu form = new frm_adminmeu();
            form.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string previous_name = txtbox_name.Text;
            string new_name = txtbox_newname.Text;
            bool flag = ProductDL.update_name(previous_name, new_name);
            if (flag == false)
            {
                lbl_error.Visible = true;
            }
            else if (flag == true)
            {
                this.Hide();
                frm_adminmeu form = new frm_adminmeu();
                form.Show();
            }
        }

        private void frm_updateproductname_Load(object sender, EventArgs e)
        {

        }
    }
}
