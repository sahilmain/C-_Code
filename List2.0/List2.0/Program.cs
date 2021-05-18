using System;
using System.Collections.Generic;
namespace List2._0
{
    class Program
    {
        static void Main(string[] args)
        {
           var empList = new List<Employee>()
            {
                new Employee(){idProp = "1", nameProp = "sahil"},
                new Employee(){idProp = "2", nameProp = "nitisha"},
                new Employee(){idProp = "3", nameProp = "sara"}
            };
            foreach(var item in empList)
            {
                Console.WriteLine(item.idProp +" "+ item.nameProp);
            }
        }
    }
    class Employee
    {
        //fields
        private string id, name;
        //properties
        public string idProp
        { get; set; }
        public string nameProp
        { get; set; }
    }
}
