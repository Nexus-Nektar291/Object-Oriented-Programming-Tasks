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
    public partial class frm_loginoptions : Form
    {
        public frm_loginoptions()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_signup f = new frm_signup();
            f.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_signin form = new frm_signin();
            form.Show();
        }

        private void frm_loginoptions_Load(object sender, EventArgs e)
        {

        }
    }
}
