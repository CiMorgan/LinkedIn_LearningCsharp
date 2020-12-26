using System;

namespace PasswordChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "";
            while (password != "secret")
            {
                Console.WriteLine("What is the password");
                password = Console.ReadLine();

                if (password != "secret")
                { 
                    Console.WriteLine("That is incorrect. You have NOT been authenticated.");
                }
            }
            Console.WriteLine("You have been authenticated!");
        }
    }
}
