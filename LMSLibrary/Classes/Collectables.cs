using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class Collectables
    {
        private SQLiteCommand cmd;
        private SQLiteDataAdapter da;
        private DataTable dt = new DataTable();
        public string msg = "";

        public async Task<bool> Add(List<CollectablesModel> collectables)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = " INSERT INTO Collectables (LoanId, BorrowerId, PerRemittance, DueDate) VALUES ";
                    foreach (CollectablesModel c in collectables)
                    {
                        query += $"('{c.Loan.Id}','{c.Borrower.Id}', '{c.Loan.PerRemittance}', '{c.DueDate}'),";
                    }
                    query = query.Substring(0, query.Length - 1);

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

        public bool DeleteCollectables(int loanId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    cmd = new SQLiteCommand($"DELETE FROM Collectables WHERE LoanId = '{loanId}'", conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        msg = "Loan has been deleted successfully!";
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
        public async Task<IEnumerable<CollectablesModel>> GetAll()
        {
            List<CollectablesModel> collectables = new List<CollectablesModel>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    conn.Open();
                    string query = "SELECT * FROM Collectables";
                    cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();

                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);

                    Loans loans = new Loans();
                    Borrowers borrowers = new Borrowers();
                    foreach (DataRow row in dt.Rows)
                    {
                        LoanModel l = await loans.GetSingle(Convert.ToInt32(row["LoanId"]));
                        BorrowerModel b = await borrowers.GetSingle(Convert.ToInt32(row["BorrowerId"]));
                        collectables.Add(new CollectablesModel()
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Loan = l,
                            Borrower = b,
                            DueDate = Convert.ToDateTime(row["DueDate"])
                        });
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return collectables;
        }


        public async Task<CollectablesModel> GetSingle(int id)
        {
            CollectablesModel collectables = new CollectablesModel();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    conn.Open();
                    string query = $"SELECT * FROM Collectables WHERE LoanId = '{id}'";
                    cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();

                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];

                    Loans loans = new Loans();
                    Borrowers borrowers = new Borrowers();
                    LoanModel l = await loans.GetSingle(Convert.ToInt32(row["LoanId"]));
                    BorrowerModel b = await borrowers.GetSingle(Convert.ToInt32(row["BorrowerId"]));
                    collectables.Id = Convert.ToInt32(row["Id"]);
                    collectables.DueDate = Convert.ToDateTime(row["DueDate"]);
                    collectables.Loan = l;
                    collectables.Borrower = b;
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return collectables;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = $"DELETE FROM Collectables WHERE Id = '{id}'";
                    cmd = new SQLiteCommand(query, conn);
                    int res = await cmd.ExecuteNonQueryAsync();

                    if (res > 0)
                    {
                        msg = "Remittance is Successfully Comitted!";
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
