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
    public partial class frm_addproduct : Form
    {
        public frm_addproduct()
        {
            InitializeComponent();
        }

        private void txtbox_role_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            addproduct();
        }
        private void btn_submit_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_name.Text) || string.IsNullOrEmpty(txtbox_type.Text) || string.IsNullOrEmpty(txtbox_price.Text))
            {
                btn_submit.Cursor = Cursors.No;
            }
            else
            {
                btn_submit.Cursor = Cursors.Default;
            }
        }
        public void addproduct()
        {
            if (txtbox_name.Text != null && txtbox_type.Text != null && txtbox_price.Text != null)
            {
                ProductBL b = new ProductBL();
                b.setname(txtbox_name.Text);
                b.settype(txtbox_type.Text);
                b.setprice(double.Parse(txtbox_price.Text));
                ProductDL.products.Add(b);
                ProductDL.storeproductinfile(ProductBL.products_path, b);
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

        private void add_product_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btn_submit_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
