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
    public partial class frm_viewrooms : Form
    {
        public frm_viewrooms()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void frm_viewrooms_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Room Name", typeof(string));
            table.Columns.Add("Room Type", typeof(string));
            table.Columns.Add("Room Price", typeof(string));

            foreach (RoomBL b in RoomDL.rooms)
            {
                table.Rows.Add(b.getName(), b.gettype(), b.getprice());
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_usermenu form = new frm_usermenu();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
