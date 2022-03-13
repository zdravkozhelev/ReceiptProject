using System;
using System.Data.SqlClient;


	
		public static class Configuration
    {
		public const string connectionString = "Server=18-05\\SQLEXPRESS; Database=Recepiesdb ; Integrated Security=true";
		public static SqlConnection GetConnection()
        {
			return new SqlConnection(connectionString);
        }
    }
