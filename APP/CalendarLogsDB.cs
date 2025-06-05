using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    internal class CalendarLogsDB
    {
        public CalendarLogsDB() { }
        string fullLog;
        string time;
        int workoutID;
        public static List<string> logList = new List<string>();
        /// <summary>
        /// Retrieves and formats all workout logs for a specific date for the current user.
        /// </summary>
        /// <param name="selectedDateString">The date to search for workouts, in 'yyyy-MM-dd' format.</param>
        public void LogMaker(string selectedDateString)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = $"SELECT WorkoutID, StartTime AS WorkoutDate FROM WorkoutSessions WHERE UserID = {LoginDB.UserId} AND StartTime Like '%{selectedDateString}%' ORDER BY StartTime;";

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
        /// <summary>
        /// Retrieves exercise details for the current workout ID.
        /// </summary>
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
                                $"----------------------------------------------------------\n";
                        }
                        reader.Close();
                    }
                }
            }
        }
        /// <summary>
        /// Returns a combined string of all logs in the static logList.
        /// </summary>
        /// <returns>Formatted string containing all logs.</returns>
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
