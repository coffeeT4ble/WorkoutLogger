using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace APP
{
    internal class GetLogDB
    {
        public GetLogDB() { }
        string fullLog;
        string time;
        int workoutID;
        public static List<string> logList = new List<string>();
        public void LogMaker()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = $"SELECT WorkoutID, StartTime AS WorkoutDate FROM WorkoutSessions WHERE UserID = {LoginDB.UserId} ORDER BY StartTime;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            workoutID = reader.GetInt32(0);
                            time = reader.GetDateTime(1).ToString("yyyy-MM-dd HH:mm:ss");
                            Details();
                            fullLog = $"" +
                                $"Workout ID: {workoutID}\n" +
                                $"{details}\n" +
                                $"Workout Date: {time}\n" +
                                $"|-------------------------------------------------|\n";
                            logList.Add(fullLog);
                        }
                        reader.Close();
                    }
                }
            }
        }
        string details;
        public void Details()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = $"SELECT e.EName AS ExerciseName, wl.WWeight, wl.WSets, wl.RepsPerSet FROM WorkoutLogs wl JOIN Exercises e ON wl.ExerciseID = e.ExerciseID WHERE wl.WorkoutID = {workoutID}";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            details = $"Exercise Name: {Convert.ToString(reader.GetString(0))}\n" +
                                $"Weight: {Convert.ToString(reader.GetDecimal(1))}\n" +
                                $"Sets: {Convert.ToString(reader.GetInt32(2))}\n" +
                                $"Reps Per Set: {Convert.ToString(reader.GetInt32(3))}\n" +
                                $"----------------------------------------------------------";
                        }
                        reader.Close();
                    }
                }
            }
        }
        public String completeLog()
        {
            string completeLog = "";
            foreach (string log in logList)
            {
                completeLog += log + "\n";
            }
            return completeLog;
        }
    }
}
