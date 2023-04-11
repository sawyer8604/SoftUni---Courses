using Microsoft.Data.SqlClient;
using MyClasses;
using System;

namespace CSharpDbDEmo
{
    class Program
    {
        static void Main(string[] args)
        {
            // .
            // localhost
            // 127.0.0.1

                    // connectionString
                    
                    //- SqlConnection
                    //  - openSqlConnection
                    
                    //- ExecuteNonQuery
                    //  - Insert, Delete, Update
                    
                    //- ExecuteScalar
                    //  - If the select query returns only one record
                    
                    //- ExecuteReader
                    //  - If the select query returns more than one record                    
                    
                    //command.Parameters.AddWithValue("@villainId", villainId);

            using (var connection = new SqlConnection("Server=.;TrustServerCertificate=True;Integrated Security=true;Database=SoftUni"))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Employees SET Salary = Salary + 0.12", connection);
                var rowsAffected = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);
            }
        }
    }
}
