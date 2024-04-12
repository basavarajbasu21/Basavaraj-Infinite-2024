using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter employee name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter employee salary >= 25000:");
            int empSalary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee type (P/C):");
            string empType = Console.ReadLine();

            string connectionString = "Server=ICS-LT-2G758G3\\SQLEXPRESS;Database=Employeemanagement;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AddEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters
                command.Parameters.AddWithValue("@EmpName", empName);
                command.Parameters.AddWithValue("@Empsal", empSalary);
                command.Parameters.AddWithValue("@Emptype", empType);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Employee added successfully.");
                }
                else
                {
                    Console.WriteLine("No rows affected. Employee not added.");
                }
                Console.ReadLine();
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
