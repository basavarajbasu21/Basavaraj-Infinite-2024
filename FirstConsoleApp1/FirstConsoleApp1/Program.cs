using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace FirstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!..Welcome to C#");
            Console.WriteLine("Enter your First name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("your firstname is :" + fname + "and your Lastname is :" + lname);
 
            Console.WriteLine("Your Firstname is :{0} your last name is: {1}", fname, lname);
            // creating the object of the class and call its function
            Program program = new Program();
            program.type_Conversion();
            Console.Read();
        }
        public void type_Conversion()
        {
            int i = 100;
            float f;
            Console.WriteLine(i);
            f = i;//implicit Conversion
            Console.WriteLine(f);
            f = 12345.50f;//suffix is use to define that it's not double it's a float value.
            Console.WriteLine(f);
            int x = (int)f;// explicit using cast operator taking risk of data loss
            Console.WriteLine(x);
            x = Convert.ToInt32(f);
            string str = "100";
            x = int.Parse(str);
            Console.WriteLine("Value of x after parsing : " + x);
        }
 
    }
}