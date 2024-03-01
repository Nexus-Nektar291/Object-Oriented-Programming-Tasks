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
    public partial class frm_addroom : Form
    {
        public frm_addroom()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            RoomBL room = new RoomBL();
            room.setname(txtbox_name.Text);
            room.setType(txtbox_type.Text);
            room.setprice(double.Parse(txtbox_price.Text));
            RoomDL.add_room(room);
            RoomDL.storeroomsinfile(RoomBL.room_path,room);
            this.Hide();
            frm_adminmeu form = new frm_adminmeu();
            form.Show();
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

        private void frm_addroom_Load(object sender, EventArgs e)
        {

        }
    }
}
