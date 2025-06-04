using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APP
{
    public class LoginDB
    {
        public static int UserId;
        public static string UserName;
        public void CheckValid(string email, string password, Form f1, Form f2)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserID, Username FROM Users WHERE Email = '" + email + "' AND PasswordHash = '" + password + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            UserId = userId;
                            UserName = reader.GetString(1);
                        }
                        reader.Close();
                        f1.Hide();
                        f2.Show();
                    }
                    else
                    {
                        
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }
    }
}
