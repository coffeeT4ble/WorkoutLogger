using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace APP
{
    internal class SignUpDB
    {
        public SignUpDB() { }
        /// <summary>
        /// Attempts to create a new user account in the database using the provided credentials.
        /// Displays message boxes indicating success or specific errors (e.g., duplicate entries or invalid email format).
        /// </summary>
        /// <param name="username">The username for the new account.</param>
        /// <param name="email">The email address for the new account.</param>
        /// <param name="password">The password (or hash) for the new account.</param>
        public void SignUp(string username, string email, string password)
        {
            try
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Users(Username, Email, PasswordHash) VALUES ('"+username+"', '"+email+"', '"+password+"');";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE") || ex.Message.Contains("duplicate"))
                {
                    MessageBox.Show("That email or username is already in use.", "Signup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("CHECK constraint") || ex.Message.Contains("Email"))
                {
                    MessageBox.Show("Invalid email format.", "Signup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
