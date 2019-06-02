using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class Users
    {
        public string msg = "";
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter da;
        private SQLiteCommand cmd;

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            List<UserModel> users = new List<UserModel>();
            msg = "";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = $"SELECT * FROM Users WHERE Status = 0;";
                    conn.Open();
                    cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();
                    da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        users.Add(new UserModel()
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Name = Convert.ToString(row["Name"]),
                            Username = Convert.ToString(row["Username"]),
                            Password = Convert.ToString(row["Password"]),
                            UserType = Convert.ToString(row["UserType"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return users;
        }
        public UserModel GetSingle(string username, int id = 0)
        {
            UserModel user = null;
            msg = "";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    string query = "";
                    if (id != 0)
                      query = $"SELECT * FROM Users WHERE Id = '{id}';";
                    else
                      query = $"SELECT * FROM Users WHERE Username = '{username}';";
                   
                    da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];

                    user = new UserModel()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = Convert.ToString(row["Name"]),
                        Username = Convert.ToString(row["Username"]),
                        UserType = Convert.ToString(row["UserType"])
                    };
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return user;
        }

        public async Task<bool> Add(UserModel user)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Name, Username, Password, UserType) " + 
                        $"VALUES( '{user.Name}', '{user.Username}', '{user.Password}', '{user.UserType}')";
                    cmd = new SQLiteCommand(query, conn);
                    int res = await cmd.ExecuteNonQueryAsync();
                    if (res > 0)
                    {
                        cmd = new SQLiteCommand("SELECT last_insert_rowid()", conn);
                        Int64 id = Convert.ToInt64(await cmd.ExecuteScalarAsync());
                        int _userId = (int)id;
                        await AddAttempt(_userId);
                        msg = "User is added successfully!";
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return false;
        }


        public async Task<bool> AddAttempt(int userId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = "INSERT INTO LoginAttempt (UserId) " +
                        $"VALUES('{userId}')";
                    cmd = new SQLiteCommand(query, conn);
                    int res = await cmd.ExecuteNonQueryAsync();
                    if (res > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return false;

        }

        public async Task<bool> Update(UserModel user, int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = $"UPDATE Users SET Name = '{user.Name}', Username = '{user.Username}', Password = '{user.Password}', " +
                        $"UserType = '{user.UserType}' WHERE Id = '{id}';";
                    cmd = new SQLiteCommand(query, conn);
                    int res = await cmd.ExecuteNonQueryAsync();
                    if (res > 0)
                    {
                        msg = "User is updated successfully!";
                        return true;
                    }
                    msg = "Failed to update user! Please try again.";
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return false;
            
        }

        public async Task<bool> Delete(int id, bool isAdmin = false)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    if (isAdmin)
                    {
                        if (ifAdminOne())
                        {
                            msg = "Sorry you can't delete all admin!";
                            return false;
                        }
                    }
                  
                    conn.Open();
                    string query = $"UPDATE Users SET Status = 1 WHERE Id = '{id}';";
                    cmd = new SQLiteCommand(query, conn);
                    int res = await cmd.ExecuteNonQueryAsync();
                    if (res > 0)
                    {   
                        msg = "User is deleted successfully!";
                        return true;
                    }
                    msg = "Failed to delete user! Please try again.";
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return false;

        }

        public bool ifAdminOne()
        {
            try
            {
                dt.Clear();
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    string query = $"SELECT * FROM Users WHERE Status = 0;";
                    da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);
                    int count = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (Convert.ToString(row["UserType"]) == "admin")
                        {
                            count++;
                        }
                    }

                    if (count == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return false;
        }

        public bool IfUsernameExist(string username)
        {
            try
            {
                dt.Clear();
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    string query = $"SELECT * FROM Users WHERE Username = '{username}';";
                    da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0 )
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return false;
        }
    }
}
