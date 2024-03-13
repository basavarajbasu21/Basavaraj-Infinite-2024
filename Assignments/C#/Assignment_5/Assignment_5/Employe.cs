using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public int EmpId { get; }
        public string EmpName { get; }
        public float Salary { get; }

        public Employee(int empId, string empName, float salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public float Wages { get; }

        public PartTimeEmployee(int empId, string empName, float salary, float wages) : base(empId, empName, salary)
        {
            Wages = wages;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details for Full-time Employee:");
            Console.Write("Employee ID: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee Name: ");
            string empName = Console.ReadLine();
            Console.Write("Salary: ");
            float salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nEnter details for Part-time Employee:");
            Console.Write("Employee ID: ");
            int partTimeEmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee Name: ");
            string partTimeEmpName = Console.ReadLine();
            Console.Write("Salary: ");
            float partTimeSalary = Convert.ToSingle(Console.ReadLine());
            Console.Write("Wages: ");
            float wages = Convert.ToSingle(Console.ReadLine());

            Employee fullTimeEmployee = new Employee(empId, empName, salary);
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(partTimeEmpId, partTimeEmpName, partTimeSalary, wages);

            Console.WriteLine("\nDetails of Full-time Employee:");
            Console.WriteLine($"Employee ID: {fullTimeEmployee.EmpId}");
            Console.WriteLine($"Employee Name: {fullTimeEmployee.EmpName}");
            Console.WriteLine($"Salary: {fullTimeEmployee.Salary}");

            Console.WriteLine("\nDetails of Part-time Employee:");
            Console.WriteLine($"Employee ID: {partTimeEmployee.EmpId}");
            Console.WriteLine($"Employee Name: {partTimeEmployee.EmpName}");
            Console.WriteLine($"Salary: {partTimeEmployee.Salary}");
            Console.WriteLine($"Wages: {partTimeEmployee.Wages}");

            Console.ReadLine();

        }
    }
}
