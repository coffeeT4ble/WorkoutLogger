using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    internal class ConnectToDB
    {
        string conn_string = "Server=193.85.203.188;Database=malhotra;User Id=malhotra;Password=fXd8BQ9KCi;";
        public ConnectToDB() { }

        public void Connect()
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connected to database successfully.");
                    //MessageBox.Show("Connected to database successfully.");

                    /*string sql = "SELECT TOP 10 * FROM YourTable";
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0]);
                    }

                    reader.Close();
                    */
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
