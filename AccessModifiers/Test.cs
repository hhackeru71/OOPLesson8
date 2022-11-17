using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson8.AccessModifiers
{

    //הרשאות גישה
    public class Test:SuperTest
    {
        //public
        //private
        //protected
        //intrenal



        //private  אך ורק ניתן לגשת מאותה מחלקה
        //private int num1 = 0;
        // private int Num1 { get; set; }

        int age;

        public int num2 = 1;
        //public Test(int num1)
        //{
        //    //Num1 = num1;

        //}

        public void Test1()
        {
            Console.WriteLine(sum);
        }
        
        public void Print()
        {
            //Console.WriteLine(num1);
        }
    }

   public class SuperTest
    {
        protected int sum;

        public void Print()
        {
            Console.WriteLine(sum);
        }
    }
}
