using Gui_hotelmanagementsystem.BL;
using Gui_hotelmanagementsystem.DL;
using Gui_hotelmanagementsystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_hotelmanagementsystem
{
    public partial class frm_signin : Form
    {
        public frm_signin()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string userrole = "";
            foreach (PersonBL b in PersonDL.personBL_list)
            {
                if (b.getname() == txtbox_name.Text && b.getpassword() == txtbox_password.Text && b.getrole() == txtbox_role.Text)
                {
                    if (txtbox_role.Text == "admin")
                    {
                        userrole = "admin";
                        break;
                    }
                    if (txtbox_role.Text == "user")
                    {
                        userrole = "user";
                        break;
                    }
                }
            }
            if (userrole == "admin")
            {
                this.Hide();
                frm_adminmeu form = new frm_adminmeu();
                form.Show();
            }
            if (userrole == "user")
            {
                this.Hide();
                frm_usermenu form = new frm_usermenu();
                form.Show();
            }
        }

        private void btn_submit_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_name.Text) || string.IsNullOrEmpty(txtbox_password.Text) || string.IsNullOrEmpty(txtbox_role.Text))
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
            frm_loginoptions form = new frm_loginoptions();
            form.Show();
        }

        private void frm_signin_Load(object sender, EventArgs e)
        {

        }
    }
}
