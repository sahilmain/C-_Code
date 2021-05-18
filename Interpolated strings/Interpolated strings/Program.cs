using System;

namespace Interpolated_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string first = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string last = Console.ReadLine();
            Console.WriteLine($"Owner's name is {first} {last}");
            Console.WriteLine($"Owner's name is last first fashion {last} {first}");
            Console.WriteLine($"length of name = {first.Length + last.Length}");
        }
    }
}
