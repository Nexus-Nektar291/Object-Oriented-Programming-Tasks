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
    public partial class frm_usermenu : Form
    {
        public frm_usermenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_abouthotel form = new frm_abouthotel();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_viewproducts form = new frm_viewproducts();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_loginoptions form = new frm_loginoptions();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_viewrooms form = new frm_viewrooms();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_feedback form = new frm_feedback();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_orderproduct form = new frm_orderproduct();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_bookroom form = new frm_bookroom();
            form.Show();
        }

        private void frm_usermenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_loginoptions frm = new frm_loginoptions();
            frm.Show();
        }
    }
}
