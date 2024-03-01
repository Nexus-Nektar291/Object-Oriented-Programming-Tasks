using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_hotelmanagementsystem.BL
{
    public class AdminBL : PersonBL
    {
        public AdminBL(string name, string password) : base(name, password, "admin")
        {
        }
    }
}
