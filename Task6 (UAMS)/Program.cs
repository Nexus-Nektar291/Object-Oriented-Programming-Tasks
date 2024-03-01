using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversityManSys.BL;

namespace UniversityManSys
{
    internal class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<DegreeProgram> programs = new List<DegreeProgram>();
        
        static void Main(string[] args)
        {
            Char option;
            do
            {
                option = Menu();
                if (option == '1')
                {
                    if (programs.Count > 0)
                    {
                        Student s = student_input();
                        add_student_list(s);
                    }
                }
                else if (option == '2')
                {
                    DegreeProgram dp = degree_input();
                    add_degree(dp);
                }
                else if (option == '3')
                {
                    List<Student> sortedstudentList = new List<Student>();
                    sortedstudentList = sortStudents_ByMerit();
                    got_admission(sortedstudentList);
                    view_allStudents();
                }
                else if (option == '4')
                {
                    view_regStudents();
                }
                else if (option == '5')
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    view_degreeStudents(degName);
                }
                else if (option == '6')
                {
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Student s = studentPresent(name);
                    if (s != null)
                    {
                        view_subjects(s);
                        registerSubject(s);
                    }
                }
                else if (option == '7')
                {
                    calculateFeeForAll();
                }
                clearScreen();
            }
            while (option != '8');
            Console.ReadKey();
        }
        static Student studentPresent(string name)
        {
            foreach (Student s in studentList)
            {
                if (name == s.Name && s.RegDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        static void calculateFeeForAll()
        {
            foreach (Student s in studentList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine(s.Name + " has " + s.calculateFee() + " fees");
                }
            }
        }
        static void registerSubject(Student s)
        {
            Console.Write("Enter how many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter the Subject Code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.RegDegree.Subjects)
                {
                    if (code == sub.Code && !(s.RegSubject.Contains(sub)))
                    {
                        s.reg_subject(sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    i--;
                }
            }

        }
        static List<Student> sortStudents_ByMerit()
        {
            List<Student> sortedstudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.merit_calculate();
            }
            sortedstudentList = studentList.OrderByDescending(o => o.Merit).ToList();
            return sortedstudentList;
        }
        static void got_admission(List<Student> sortedStList)
        {
            foreach (Student s in sortedStList)
            {
                foreach (DegreeProgram d in s.Preferences)
                {
                    if (d.Seats > 0 && s.RegDegree == null)
                    {
                        s.RegDegree = d;
                        d.Seats--;
                        break;
                    }
                }
            }
        }
        static void view_allStudents()
        {
            foreach (Student s in studentList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine(s.Name + " got Admission in " + s.RegDegree.degree_name);
                }
                else
                {
                    Console.WriteLine(s.Name + "did not get Admission");
                }
            }
        }
        static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
            Console.Clear();
        }
        static void view_degreeStudents(string degName)
        {
            Console.WriteLine("Name\tFCS\tECAT\tAGE");
            foreach (Student s in studentList)
            {
                if (s.RegDegree == null)
                {
                    if (degName == s.RegDegree.degree_name)
                    {
                        Console.WriteLine(s.Name + "\t" + s.FscMarks + "\t" + s.EcatMarks + "\t" + s.Age);

                    }
                }
            }
        }
        static void view_regStudents()
        {
            Console.WriteLine("Name\tFCS\tECAT\tAGE");
            foreach (Student s in studentList)
            {
                if (s.RegDegree != null)
                {

                    Console.WriteLine(s.Name + "\t" + s.FscMarks + "\t" + s.EcatMarks + "\t" + s.Age);


                }
            }
        }
        static void add_degree(DegreeProgram d)
        {
            programs.Add(d);
        }
        static DegreeProgram degree_input()
        {
            string degree_name;
            float degreeDuration;
            int seats;
            Console.Write("Enter Degree Name: ");
            degree_name = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats for Degree: ");
            seats = int.Parse(Console.ReadLine());
            DegreeProgram degpro = new DegreeProgram(degree_name, degreeDuration, seats);
            Console.Write("Enter how many Subjects you want to enter: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                degpro.addSubject(subject_input());
            }
            return degpro;
        }
        static Subject subject_input()
        {
            string code, type;
            int creditHours, subjectFees;
            Console.Write("Enter Subject Code: ");
            code = Console.ReadLine();
            Console.Write("Enter Subject type: ");
            type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: ");
            creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            subjectFees = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, creditHours, subjectFees);
            return sub;
        }
        static void add_student_list(Student s)
        {
            studentList.Add(s);
        }
        static Student student_input()
        {
            string name;
            int age;
            double fscMarks, ecatMarks;
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSC Marks: ");
            fscMarks = double.Parse(Console.ReadLine());
            Console.Write("Enter Student ECAT Marks: ");
            ecatMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs");
            view_degree_programs();
            Console.Write("Enter how many preferences to Enter: ");
            int Count = int.Parse(Console.ReadLine());
            for (int i = 0; i < Count; i++)
            {
                string degName = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram dp in programs)
                {
                    if (degName == dp.degree_name && !(preferences.Contains(dp))) ;
                    {
                        preferences.Add(dp);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program Name");
                    i--;
                }
            }
            Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        static void view_degree_programs()
        {
            foreach (DegreeProgram dp in programs)
            {
                Console.WriteLine(dp.degree_name);
            }
        }
        static void heading()
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("                   UNIVERSITY   ADDMISION   MANAGEMENT   SYSTEM                 ");
            Console.WriteLine("********************************************************************************");
        }
        static void view_subjects(Student s)
        {
            if (s.RegDegree != null)
            {
                Console.WriteLine("Sub Code\tSub Type");
                foreach (Subject sub in s.RegDegree.Subjects)
                {
                    Console.WriteLine(sub.Code + "\t\t" + sub.Type);
                }
            }
        }
        static Char Menu()
        {
            heading();
            Char option;
            Console.WriteLine("1. Add Students");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a Specific Program");
            Console.WriteLine("6. Register Subjects for a Specific Student");
            Console.WriteLine("7. Calculate Fees for all Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Option: ");
            option = Char.Parse(Console.ReadLine());
            return option;
        }
    }
}
