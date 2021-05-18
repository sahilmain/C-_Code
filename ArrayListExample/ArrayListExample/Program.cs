using System;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var al = new ArrayList();
            //add value using loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter value " + (i + 1));
                al.Add(Console.ReadLine());
            }

            foreach (var item in al)
            {
                Console.WriteLine(item.GetType());
            }

            //add value directly
            var al2 = new ArrayList() { 1, 2, 3, "yy", "sfdf" };
            foreach (var item in al2)
            {
                Console.Write(item.GetType() + "\t");
            }
            Console.WriteLine();
            //use AddRange(Collection) method

            int[] arr = { 1, 2, 3, 4 };
            al2.AddRange(arr);
            foreach (var item in al2)
            {
                Console.Write(item  + "\t");
            }

            //insert at pos
            al2.Insert(3,"Hello");
            //insert whole collection at a pos
            var q = new Queue();
            q.Enqueue('o');
            al2.InsertRange(1,q);
            foreach (var item in al2)
            {
                Console.WriteLine(item + "\t");
            }

            //contains func
            Console.WriteLine(al2.Contains('o'));

          

            //Remove first occurence
            al2.Remove("hello");
            //Remove at index
            al2.RemoveAt(2);
            //Remove range
            al2.RemoveRange(0, 4);

            //length of AL
            Console.WriteLine(al2.Count);
            //capacity AL
            Console.WriteLine(al2.Capacity);
        }
    }
}
