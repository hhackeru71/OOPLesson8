
using OOPLesson8.Hw;
using System.Globalization;

namespace OOPLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Person[] person = new Person[2];
            person[0] = new Customer("asd", "hadera", "sdfsdfsdfsdfsdfsdf@gmail.com");
            person[1] = new Employee(5000, "yarin", "sddsf@gmail;.com");
            foreach (var item in person)
            {
                item.PrintInfo();
            }
        }
    }
}