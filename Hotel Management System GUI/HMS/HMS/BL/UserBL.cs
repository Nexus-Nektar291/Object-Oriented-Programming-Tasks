using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_hotelmanagementsystem.BL
{
    public class UserBL : PersonBL
    {
        public UserBL(string name, string password) : base(name, password, "user") { }
       
    }
}
