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
    public partial class frm_abouthotel : Form
    {
        public frm_abouthotel()
        {
            InitializeComponent();
        }

        private void frm_abouthotel_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_usermenu form = new frm_usermenu();
            form.Show();
        }
    }
}
