using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManSys.BL
{
    public class Subject
    {
        public string Code;
        public string Type;
        public int CreditHours;
        public int SubjectFees;
        public Subject(string code, string type, int creditHours, int subjectFees)
        {
            this.Code = code;
            this.Type = type;
            this.CreditHours = creditHours;
            this.SubjectFees = subjectFees;
        }
    }

}
