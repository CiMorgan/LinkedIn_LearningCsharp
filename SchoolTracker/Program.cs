using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            bool adding = true;

            while (adding)
            {
                var newStudent = new Student();
                newStudent.Name = Util.Console.Ask("Student's name:");
                newStudent.Grade = int.Parse(Util.Console.Ask("Student's grade:"));
                newStudent.Birthday = Util.Console.Ask("Student's birthdate:");
                newStudent.Address = Util.Console.Ask("Student's address:");
                newStudent.Phone = (int.Parse(Util.Console.Ask("What is the phone number?")));

                students.Add(newStudent);
                Student.Count++;
                System.Console.WriteLine("Student Count: {0}", Student.Count);

                System.Console.WriteLine("Add another student? y/n");
                if (System.Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in students)
            {
                System.Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }

        }

        static void Import()
        {
            var ImportedStudent = new Student("Jim", 86, "Jun 13 1999", "123 Butterfly Lane", 1234567);
            Console.WriteLine(ImportedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected int phone;
        public int Phone
        {
            set { phone = value; }
        }
    }
    
    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;

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
    class Teacher : Member
    {
        public string Subject;
    }

}

