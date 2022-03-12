using System;

public class Class1
{
	public Class1()
	{
		public static class Database
    {
		private static string connectionString = "Server=18-05\SQLEXPRESS.; Database=Recepies ; Integrated Security=true";
		public static SqlConnection GetConnection()
        {
			return new SqlConnection(connectionString);
        }
    }
	}
}
