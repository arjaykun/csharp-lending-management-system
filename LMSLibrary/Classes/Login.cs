using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace LMSLibrary.Classes
{
    public class Login
    {
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter da;
        private SQLiteCommand cmd;
        public string msg = "";

        public bool login(UserModel user)
        {
            msg = "";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    conn.Open();
                    string query = "";
                    int attempt = 0;
                    DateTime date;

                    query = $"SELECT * FROM Users WHERE Username = '{user.Username}';";
                    
                    da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);
                    
                    if (dt.Rows.Count > 0)
                    {
                        int id = Convert.ToInt32(dt.Rows[0]["Id"]);
                        da = new SQLiteDataAdapter($"SELECT * FROM LoginAttempt WHERE UserId = '{id}'", conn);
                        DataTable dt2 = new DataTable();
                        da.Fill(dt2);
                        DataRow a = dt2.Rows[0];
                        attempt = Convert.ToInt32(a["Attempt"]);
                        date = (Convert.ToString(a["Date"]) == "") ? DateTime.Now : Convert.ToDateTime(a["Date"]);
                        DateTime now = DateTime.Now;
                        
                        if (date > now)
                        {
                            TimeSpan span = date.Subtract(now);
                            msg = $"Please try again after {span.Minutes} minutes and {span.Seconds} seconds.";
                            return false;
                        }

                        if (attempt <= 3 )
                        {
                            string password = Convert.ToString(dt.Rows[0]["Password"]);
                            if (password == user.Password)
                            {
                                cmd = new SQLiteCommand($"UPDATE LoginAttempt SET Attempt = '{0}', Date='{now}' WHERE UserId = '{id}'", conn);
                                cmd.ExecuteNonQuery();
                                msg = $"{user.Username} has successfully logged in!";
                                cmd.Dispose();
                                return true;
                            }
                            cmd = new SQLiteCommand($"UPDATE LoginAttempt SET Attempt = '{attempt + 1}' WHERE UserId = '{id}'", conn);
                            cmd.ExecuteNonQuery();
                            if (attempt == 2)
                                msg = "Warning! You have reached 3 failed attempts to login.";
                            else
                                msg = "Warning! Invalid Username/ Password.";

                            if (attempt == 3)
                            {
                                DateTime newDate = DateTime.Now.AddMinutes(15);
                                cmd = new SQLiteCommand($"UPDATE LoginAttempt SET Attempt = '{0}', Date='{newDate}' WHERE UserId = '{id}'", conn);
                                cmd.ExecuteNonQuery();
                                msg = "Warning! You have reached the maximum attempt to login. Please wait for another 15 minutes to try again.";
                          
                                return false;
                            }
                            //disposed hahahaha
                            cmd.Dispose();
                            return false;
                        }
                    }
                    msg = "Warning! Invalid Username/ Password.";
                }
            }
            catch (Exception ex)
            {
                msg =  ex.Message;
            }
            return false;
        }

        public IEnumerable<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>();
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                string query = "";

                query = "SELECT * FROM Admin;";


                da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new UserModel() {
                        Username = Convert.ToString(row["Username"]),
                        Password = Convert.ToString(row["Password"])
                     });
                }  
            }

            return users;
        }
    }
}
