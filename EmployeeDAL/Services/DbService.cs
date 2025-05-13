using Microsoft.Data.SqlClient;

namespace EmployeeDAL.Services
{
    public class DbService
    {
        private readonly string _connectionString;

        public DbService()
        {
            _connectionString = "Server=SF-CPU-0159\\SQLEXPRESS01;Database=DesignPatterns;Trusted_Connection=True;Encrypt=False;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
