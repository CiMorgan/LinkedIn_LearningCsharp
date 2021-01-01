using System;

namespace outreference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;
            var y = 2;
            Console.WriteLine(x);
            Five(out x);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Double(ref y);
            Console.WriteLine(y);
        }
        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        static void Double(ref int a)
        {
            a = 2*a;
            Console.WriteLine(a);
        }
    }
}
