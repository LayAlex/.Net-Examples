using System;

namespace Encapsulation
{
    class Employee
    {
        public string Name { get; set; }

        protected decimal salary;
    }

    class Boss : Employee
    {
        public void SetSalary(decimal value)
        {
            salary = value;
        }

        public decimal GetSalary()
        {
            return salary;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var boss = new Boss();
            boss.SetSalary(5000);

            Console.WriteLine(boss.GetSalary());
            Console.ReadKey();
        }
    }
}
