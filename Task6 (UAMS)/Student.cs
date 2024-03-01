using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UniversityManSys.BL
{
    public class Student
    {
        public string Name;
        public int Age;
        public double FscMarks;
        public double EcatMarks;
        public double Merit;
        public List<DegreeProgram> Preferences;
        public List<Subject> RegSubject;
        public DegreeProgram RegDegree;
        public Student(string name, int age, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
        {
            this.Name = name;
            this.Age = age;
            this.FscMarks = fscMarks;
            this.EcatMarks = ecatMarks;
            this.Preferences = preferences;
            this.RegSubject = new List<Subject>();
        }
        public void merit_calculate()
        {
            Merit = (((FscMarks / 1100) * 0.45f) + ((EcatMarks / 400) * 0.55f)) * 100;
        }
        public bool reg_subject(Subject subject)
        {
            int stCh = getCreditHours();
            if (RegDegree == null && RegDegree.isSubjectExits(subject) && stCh + subject.CreditHours <= 9)
            {
                RegSubject.Add(subject);
                return true;
            }
            return false;

        }
        public int getCreditHours()
        {
            int count = 0;
            foreach (Subject s in RegSubject)
            {
                count = count + s.CreditHours;
            }
            return count;
        }
        public float calculateFee()
        {
            float fee = 0;
            if (RegDegree != null)
            {
                foreach (Subject s in RegSubject)
                {
                    fee = fee + s.SubjectFees;
                }
            }
            return fee;
        }

    }
}
