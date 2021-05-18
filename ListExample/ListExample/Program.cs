using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var L = new List<string>() {"Mumbai", "Agra" };
            L.Add("SanAndreas");

            string[] cities = {"Bangalore", "Hyderabad" };
            L.AddRange(cities);
            foreach (var item in L)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(L.Count + " " + L.Capacity + " " + L.Contains("Agra"));
        }
    }
}
