using System;

namespace SurveyChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine("What is your name?");
            customer.Name = TryAnswer();

            Console.WriteLine("How old are you?");
            customer.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born?");
            customer.BirthMonth = TryAnswer();

            customer.Display();


        }
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            { 
                Console.WriteLine("You didn't type anything, please try again.");
                return Console.ReadLine();
            }
            return answer;
        }
    }
    class Customer
    {
        public string Name;
        public int Age;
        public string BirthMonth;

        public Customer() { }

        public Customer(string name, int age, string birthMonth)
        {
            Name = name;
            Age = age;
            BirthMonth = birthMonth;
        }
        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", BirthMonth);
            if (BirthMonth == "march")
            {
                Console.WriteLine("You are an Arias.");
            }
            else if (BirthMonth == "april")
            {
                Console.WriteLine("You are a Taurus.");
            }
            else if (BirthMonth == "may")
            {
                Console.WriteLine("You are a Gemini.");
            }
        }

    }
}
