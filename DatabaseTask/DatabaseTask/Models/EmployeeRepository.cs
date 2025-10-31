using DatabaseTask.Core.Domain;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseTask.Models
{
  
    public class EmployeeRepository
    {
        private string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Employee> GetEmployeesByProject(int projectId)
        {
            var employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.GetEmployeesByProject", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            Id = reader.IsDBNull(reader.GetOrdinal("EmployeeId"))
                                ? Guid.Empty
                                : reader.GetGuid(reader.GetOrdinal("EmployeeId")),
                            LastName = reader["Name"]?.ToString() ?? "",
                            FirstName = reader["Position"]?.ToString() ?? ""
                        });
                    }
                }
            }

            return employees;
        }
    }
}
