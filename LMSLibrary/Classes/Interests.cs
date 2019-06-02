using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class Interests
    {
        public string msg = "";
        public IEnumerable<InterestModel> Get()
        {
            List<InterestModel> interests = new List<InterestModel>();
            DataTable dt = new DataTable();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    string query = "SELECT * FROM Interests";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            interests.Add(
                               new InterestModel()
                               {
                                   Id = Convert.ToInt32(row["Id"]),
                                   Description = Convert.ToString(row["Description"]),
                                   Rate = Convert.ToDouble(row["Rate"])
                               }
                            );
                        }
                    }
                    else
                        msg = "There is no data in the database yet";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return interests;
            
        }

        public double getInterest(int id)
        {
            double interest = 0;
            try
            {
                DataTable dt = new DataTable();
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    string query = $"SELECT * FROM Interests WHERE Id = {id}";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    interest = Convert.ToDouble(row["Rate"]);
                }
            }
            catch ( Exception ex)
            {
                msg = ex.Message;
            }

            return interest;
        }

        public string GetPaymentTerm(int id)
        {
            string term = "";
            try
            {
                DataTable dt = new DataTable();
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    string query = $"SELECT * FROM Interests WHERE Id = '{id}'";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    term = Convert.ToString(row["Description"]);
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return term;
        }

        public async Task<bool> Update(decimal rate, int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = $"UPDATE Interests SET Rate = '{rate}' WHERE Id = '{id}'";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    int res = await cmd.ExecuteNonQueryAsync();
                    if (res > 0)
                    {
                        msg = "Interest Rate is updated successfully!";
                        return true;
                    }
                    msg = "Failed to update interest rate! please try again.";
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
