using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APP
{
    internal class LoginDB
    {
        public void CheckValid(string email, string password)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserID FROM Users WHERE Email = '" + email + "' AND PasswordHash = '" + password + "'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // User exists, proceed with login
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            // Handle successful login, e.g., store userId or redirect
                        }
                    }
                    else
                    {
                        // User does not exist, handle invalid login
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //throw new Exception("Invalid username or password.");
                    }
                }
            }
        }
    }
}
