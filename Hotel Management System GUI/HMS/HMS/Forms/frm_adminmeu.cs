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
    public partial class frm_adminmeu : Form
    {
        public frm_adminmeu()
        {
            InitializeComponent();
        }

        private void lbl_signin_Click(object sender, EventArgs e)
        {

        }

        private void Admin_menu_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_addproduct form = new frm_addproduct();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_viewproducts form = new frm_viewproducts();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_deleteproduct form = new frm_deleteproduct();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_updateproductname form = new frm_updateproductname();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_updateproductprice form = new frm_updateproductprice();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_addroom form=new frm_addroom();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_viewrooms form = new frm_viewrooms();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_userdetails form = new frm_userdetails();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_loginoptions form=new frm_loginoptions();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_loginoptions frm=new frm_loginoptions();
            frm.Show();
        }
    }
}
