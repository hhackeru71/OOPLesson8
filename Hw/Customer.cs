using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson8.Hw
{
    internal class Customer :Person
    {
        public Customer(string name, string address ,string email)
          :base(name, address)
        {
            Email = email;
        }
        public string Email { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine(GetInfo() +" " +" "+ Email);
        }
    }
}
