using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCase
{
    class UpperCase
    {
        static void Main()
        {

            UpperCase myProgram = new UpperCase();
            Console.WriteLine("Enter First Name : ");
            myProgram.FirstName = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Last Name : ");
            myProgram.LastName = Console.ReadLine().ToUpper();
            Display(myProgram.FirstName, myProgram.LastName);

            Console.ReadLine(); 
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        static void Display(string firstName, string lastName)
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
    }
}
