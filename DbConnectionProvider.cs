using System.Configuration;
using System.Data.SqlClient;

namespace CRUD
{
  public class DbConnectionProvider
  {
    public static SqlConnection GetConnection =
      new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
    
    private DbConnectionProvider() { }
  }
}