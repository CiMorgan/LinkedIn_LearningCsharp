using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            bool adding = true;

            while (adding)
            {
                Console.WriteLine("What is the students's name?");
                studentNames.Add(Console.ReadLine());
                Console.WriteLine($"What is the grade?");
                studentGrades.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Add another student? y/n");
                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
            
        }
    }
}
