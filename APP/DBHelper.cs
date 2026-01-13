using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public static class DBHelper
    {
        private static readonly string conn_string = "Server=193.85.203.188;Database=malhotra;User Id=malhotra;Password=@fXd8BQ9KCi;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conn_string);
        }
    }
}
