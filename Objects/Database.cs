using System;
using System.Data;
using System.Data.SqlClient;

namespace coreNancy
{
  public class DB
  {
    public static SqlConnection Connection()
    {
      SqlConnection conn = new SqlConnection(DBConfiguration.ConnectionString);
      if (conn != null)
      {
        Console.WriteLine("DB CONNECTED");
      }
      return conn;
    }
  }

}
