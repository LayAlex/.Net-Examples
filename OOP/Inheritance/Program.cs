using System;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }

        public void ShowName()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public string CompanyName { get; set; }

        public void ShowCompany()
        {
            Console.WriteLine(CompanyName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();

            employee.Name = "Bob";
            employee.CompanyName = "MyCompany";

            employee.ShowName();
            employee.ShowCompany();

            Console.ReadKey();
        }
    }
}
