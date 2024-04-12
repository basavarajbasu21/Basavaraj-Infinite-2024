using System;
using System.Data;
using System.Data.SqlClient;

class Add
{
    static void Main()
    {
        string connectionString = "Server=ICS-LT-2G758G3\\SQLEXPRESS;Database=Employeemanagement;Integrated Security=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Employee_Details", connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Empno: {reader["Empno"]}, EmpName: {reader["EmpName"]}, Empsal: {reader["Empsal"]}, Emptype: {reader["Emptype"]}");
            }
            Console.ReadLine();

        }
    }
}
