using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManSys.BL
{
    public class DegreeProgram
    {
        public string degree_name;
        public float degree_duration;
        public List<Subject> Subjects;
        public int Seats;
        public DegreeProgram(string degree_name, float degree_duration, int seats)
        {
            this.degree_name = degree_name;
            this.degree_duration = degree_duration;
            this.Subjects = new List<Subject>();
            this.Seats = seats;
        }
        public int cal_credit_hours()
        {
            int count = 0;
            for (int i = 0; i < Subjects.Count; i++)
            {
                count = count + Subjects[i].CreditHours;
            }
            return count;
        }
        public bool addSubject(Subject subject)
        {
            int creditHours = cal_credit_hours();
            if (creditHours + subject.CreditHours <= 20)
            {
                Subjects.Add(subject);
                return true;
            }
            return false;
        }
        public bool isSubjectExits(Subject subject)
        {
            foreach (Subject s in Subjects)
            {
                if (s.Code == subject.Code)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
