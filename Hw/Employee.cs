using OOPLesson8.Hw.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson8.Hw
{
    internal class Employee : Person, ICalculate
    {
        public double Salary { get; set; }
        public Employee(double salary, string name, string address)
            :base(name,address)
        {
            Salary = salary;
        }

        public double DivideSalary()
        {
            return Salary / 10;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{GetInfo() +" "+" "+ DivideSalary()}");
            
        }
    }
}
