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

namespace Gui_hotelmanagementsystem
{
    public partial class frm_signup : Form
    {
        public frm_signup()
        {
            InitializeComponent();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            txtbox_name.Text = "";
            txtbox_password.Text = "";
        }
        public void signup_person()
        {
            if (txtbox_name.Text != null && txtbox_password.Text != null && (txtbox_role.Text == "admin" || txtbox_role.Text == "user"))
            {
                txtbox_role.Text.ToLower();
                PersonBL b = new PersonBL(txtbox_name.Text, txtbox_password.Text, txtbox_role.Text);
                PersonDL.personBL_list.Add(b);
                PersonDL.Storepersoninfile(PersonBL.person_path,b);
                this.Hide();
                frm_loginoptions form = new frm_loginoptions();
                form.Show();
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            signup_person();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_loginoptions form = new frm_loginoptions();
            form.Show();
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
    }
}
