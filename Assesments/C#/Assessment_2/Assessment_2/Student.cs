using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Abstract class called  Student with  Name, StudentId, Grade as members -----");

            // Test with Undergraduate student
            Undergraduate undergradStudent = new Undergraduate
            {
                Name = "BASAVARAJ MAGADUM",
                StudentId = 1034337,
                Grade = 75.0
            };



            Console.WriteLine($"Undergraduate Student: {undergradStudent.Name}, ID: {undergradStudent.StudentId}, Grade: {undergradStudent.Grade}");
            Console.WriteLine($"Is Passed: {undergradStudent.IsPassed(undergradStudent.Grade)}\n");
            //Console.ReadLine();

            // Test with Graduate student
            Graduate gradStudent = new Graduate
            {
                Name = "SHANTESH DESAI",
                StudentId = 9353468,
                Grade = 85.0
            };

            Console.WriteLine($"Graduate Student: {gradStudent.Name}, ID: {gradStudent.StudentId}, Grade: {gradStudent.Grade}");
            Console.WriteLine($"Is Passed: {gradStudent.IsPassed(gradStudent.Grade)}");
            Console.ReadLine();
        }
    }
}
