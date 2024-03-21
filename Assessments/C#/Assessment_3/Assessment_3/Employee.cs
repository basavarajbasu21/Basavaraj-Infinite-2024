using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            
            List<Employee> empList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Basavaraj", LastName = "Magadum", Title = "Associate", DOB = DateTime.Parse("21/07/2001"), DOJ = DateTime.Parse("15/02/2024"), City = "Hyderabad" },
            new Employee { EmployeeID = 1002, FirstName = "Shashikanth", LastName = "Nivalagi", Title = "AsstManager", DOB = DateTime.Parse("10/01/2001"), DOJ = DateTime.Parse("25/02/2024"), City = "Belagavi" },
            new Employee { EmployeeID = 1003, FirstName = "Shantesh", LastName = "Nivalagi", Title = "SE", DOB = DateTime.Parse("14/02/2001"), DOJ = DateTime.Parse("19/02/2024"), City = "Bengaluru" },
            new Employee { EmployeeID = 1004, FirstName = "Adharsha", LastName = "B", Title = "SE", DOB = DateTime.Parse("15/03/2001"), DOJ = DateTime.Parse("21/07/2023"), City = "Bengaluru" },
            new Employee { EmployeeID = 1005, FirstName = "Praveen", LastName = "P", Title = "OSE", DOB = DateTime.Parse("10/03/2001"), DOJ = DateTime.Parse("02/12/2023"), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Abha", LastName = "Shree", Title = "RE", DOB = DateTime.Parse("24/08/2001"), DOJ = DateTime.Parse("08/10/2023"), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Ananya", LastName = "Nazare", Title = "Network Engineer", DOB = DateTime.Parse("23/08/2001"), DOJ = DateTime.Parse("12/02/2023"), City = "Bengaluru" },
            new Employee { EmployeeID = 1008, FirstName = "Ranjita", LastName = "V R", Title = "Associate", DOB = DateTime.Parse("11/08/2001"), DOJ = DateTime.Parse("15/02/2024"), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Ajith Kumar", LastName = "C", Title = "Associate", DOB = DateTime.Parse("12/09/2001"), DOJ = DateTime.Parse("03/12/2023"), City = "Noida" },
            new Employee { EmployeeID = 1010, FirstName = "Rachana", LastName = "R", Title = "Network Engineer", DOB = DateTime.Parse("12/04/2001"), DOJ = DateTime.Parse("21/10/2023"), City = "Bengaluru" }
        };

            Console.WriteLine("-------- Employee Details --------");

            // LINQ queries
            Console.WriteLine("\na. Details of all employees:");
            DisplayEmployees(empList);

            Console.WriteLine("\nb. Details of employees not located in Mumbai:");
            var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            DisplayEmployees(employeesNotInMumbai);

            Console.WriteLine("\nc. Details of employees with title 'AsstManager':");
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            DisplayEmployees(asstManagers);

            Console.WriteLine("\nd. Details of employees whose Last Name starts with 'S':");
            var employeesWithSLastName = empList.Where(emp => emp.LastName.StartsWith("S"));
            DisplayEmployees(employeesWithSLastName);
        }

        static void DisplayEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {


                Console.WriteLine($"EmployeeID: {employee.EmployeeID}, " +
                    $"FirstName: {employee.FirstName}, " +
                    $"LastName: {employee.LastName}, " +
                    $"Title: {employee.Title}, " +
                    $"DOB: {employee.DOB.ToShortDateString()}, " +
                    $"DOJ: {employee.DOJ.ToShortDateString()}, " +
                    $"City: {employee.City}");
                Console.ReadLine();
            }
        }
    }
}
