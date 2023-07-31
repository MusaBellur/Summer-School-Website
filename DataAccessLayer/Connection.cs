using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-QE6J6UN\SQLEXPRESS;Inital Catalog=DBSummerSchool;Integrated Security=True");
    }
}