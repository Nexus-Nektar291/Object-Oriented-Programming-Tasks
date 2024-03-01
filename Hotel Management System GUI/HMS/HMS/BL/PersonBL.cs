using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_hotelmanagementsystem.BL
{
    public class PersonBL
    {
        private string name;
        private string password;
        private string role;

        public static string person_path = "persons.txt";
        public PersonBL(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public string getname()
        {
            return name;
        }
        public string getpassword()
        {
            return password;
        }
        public string getrole()
        {
            return role;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public void setrole(string role)
        {
            this.role = role;
        }
    }
}
