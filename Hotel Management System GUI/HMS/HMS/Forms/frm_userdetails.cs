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
    public partial class frm_userdetails : Form
    {
        public frm_userdetails()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void frm_userdetails_Load(object sender, EventArgs e)
        {
            table.Columns.Add("User Names ", typeof(string));
            table.Columns.Add("User Passwords ", typeof(string));
            table.Columns.Add("User Roles ", typeof(string));

            foreach (PersonBL b in PersonDL.personBL_list)
            {
                table.Rows.Add(b.getname(), b.getpassword(), b.getrole());
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_adminmeu form = new frm_adminmeu();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
