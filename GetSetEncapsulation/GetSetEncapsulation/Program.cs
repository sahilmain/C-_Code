using System;

namespace GetSetEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.idProp = 1;
            obj.nameProp = "Yash";

            Console.WriteLine(obj.idProp +" "+ obj.nameProp);
        }
    }
    class Test
    {
        /*fields are kept private because they may contain 
          sensitive data but sometimes others may need to set and get them
          for that we use concept of properties
        */
        private int id;
        private string name;

        //properties
        public int idProp
        { get; set; }

        public string nameProp 
        { get; set; }
            
    }
}
