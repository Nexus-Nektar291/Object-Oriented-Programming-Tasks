using Gui_hotelmanagementsystem.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_hotelmanagementsystem.DL
{
    public class PersonDL
    {
        public static List<PersonBL> personBL_list = new List<PersonBL>();
        public static void Storepersoninfile(string path,PersonBL b)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(b.getname() + "," + b.getpassword() + "," + b.getrole());
            streamWriter.Close();
        }
    }
}
