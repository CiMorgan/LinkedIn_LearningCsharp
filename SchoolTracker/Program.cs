using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum School
    {
        Hogwarts,
        Harvard,
        MIT
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Logger.Log("Tracker started", priority: 0);
            Payroll payroll = new Payroll();
            payroll.PayAll();
            bool adding = true;

            while (adding)
            {
                try
                {
                    Logger.Log("Adding new student");
                    var newStudent = new Student();
                    newStudent.Name = Util.Console.Ask("Student's name: ");
                    newStudent.Grade = Util.Console.AskInt("Student's grade: ");
                    newStudent.School = (School) Util.Console.AskInt("School Name (select correspondong number: \n0: Hogwarts High \n1: Harvard High \n2: MIT High \n");
                    newStudent.Birthday = Util.Console.Ask("Student's birthdate: ");
                    newStudent.Address = Util.Console.Ask("Student's address: ");
                    newStudent.Phone = Util.Console.AskInt("What is the phone number? ");

                    students.Add(newStudent);
                    Student.Count++;
                    System.Console.WriteLine("Student Count: {0}", Student.Count);

                    System.Console.WriteLine("Add another student? y/n");
                    if (System.Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (FormatException msg)
                {
                Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                Console.WriteLine("Error adding student. Please try again.");
                }
            }

            ShowGrade("Tom");
            foreach (var student in students)
            {
                System.Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
            }
            Exports();

        }

        static void Import()
        {
            var ImportedStudent = new Student("Jim", 86, "Jun 13 1999", "123 Butterfly Lane", 1234567);
            Console.WriteLine(ImportedStudent.Name);
        }
        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }
        static void ShowGrade(string name)
        {
            var found = students.Find(student => student.Name == name);
            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
    
    class Student : Member
    {
        static public int Count { get; set; } = 0;
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

        public Student() { }
        public Student(string name, int grade, string birthdate, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthdate;
            Address = address;
            Phone = phone;
        }

    }


}

