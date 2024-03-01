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
    public partial class frm_bookroom : Form
    {
        public frm_bookroom()
        {
            InitializeComponent();
        }

        private void btn_submit_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_name.Text) || string.IsNullOrEmpty(txtbox_type.Text) || string.IsNullOrEmpty(textBox1.Text))
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
            frm_usermenu form = new frm_usermenu();
            form.Show();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string roomname = txtbox_name.Text;
            string roomtype = txtbox_type.Text;
            bool flag = RoomDL.isroomexists(roomname, roomtype);
            if (flag)
            {
                this.Hide();
                frm_usermenu form=new frm_usermenu();
                form.Show();
            }
            if(flag==false)
            {
                lbl_error.Visible = true;
            }
        }

        private void frm_bookroom_Load(object sender, EventArgs e)
        {

        }
    }
}
