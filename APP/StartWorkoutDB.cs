using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal class StartWorkoutDB
    {
        public static Dictionary<string, string> exercises = new Dictionary<string, string>();
        public StartWorkoutDB() { }
        public void AddExercise()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT EName, EDescription FROM Exercises";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string exerciseName = reader.GetString(0);
                        string description = reader.GetString(1);
                        if (!exercises.ContainsKey(exerciseName))
                        {
                            exercises.Add(exerciseName, description);
                        }
                    }
                    reader.Close();
                }
            }
        }
        public string getE()
        {
            StringBuilder all = new StringBuilder();
            foreach (var kvp in exercises)
            {
                all.AppendLine($"Exercise: {kvp.Key} - Description: {kvp.Value}\n");
            }
            return all.ToString();
        }
    }
}
