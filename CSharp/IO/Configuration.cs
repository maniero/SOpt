using System.Data.SqlClient;
using System.Configuration;

public class Programa {
    public static void Main() {
        conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        conn.Open();
    }
}

//http://pt.stackoverflow.com/q/22642/101
