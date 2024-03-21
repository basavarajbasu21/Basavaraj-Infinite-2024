using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }

    public class DayScholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Day Scholar Details:");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.ReadLine();

        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Resident Details:");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.ReadLine();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of DayScholar and Resident classes
            DayScholar dayScholar = new DayScholar();
            Resident resident = new Resident();

            // Setting properties
            dayScholar.StudentId = 1;
            dayScholar.Name = "Basavaraj M";

            resident.StudentId = 2;
            resident.Name = "Shashikant";

            // Calling ShowDetails method for both instances
            dayScholar.ShowDetails();
            Console.WriteLine();
            resident.ShowDetails();
        }
    }
}
