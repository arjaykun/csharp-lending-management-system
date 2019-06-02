using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class Collections
    {
        private SQLiteCommand cmd;
        private SQLiteDataAdapter da;
        private DataTable dt = new DataTable();
        public string msg = "";

        public async Task<bool> Add(CollectionModel c)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = "INSERT INTO Collections (LoanId, BorrowerId, Amount, Date) VALUES" + 
                        $"('{c.LoanId}','{c.BorrowerId}', '{c.Amount}', '{c.Date}');"; 
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

        public async Task<IEnumerable<CollectionModel>> GetAll()
        {
            List<CollectionModel> collections = new List<CollectionModel>();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    conn.Open();
                    string query = "SELECT * FROM Collections";
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
                        collections.Add(new CollectionModel()
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Amount = Convert.ToDecimal(row["Amount"]),
                            Date = Convert.ToDateTime(row["Date"]),
                            Borrower = b,
                            Loan = l
                        });
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return collections;
        }

        public async Task<DataSet> GetDataSet()
        {
            DataSet collections = new DataSet();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    conn.Open();
                    string query = "SELECT * FROM Collections";
                    cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();

                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(collections, collections.Tables[0].TableName);

                    //Loans loans = new Loans();
                    //Borrowers borrowers = new Borrowers();
                    
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return collections;
        }

        public bool DeleteCollections(int loanId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    cmd = new SQLiteCommand($"DELETE FROM Collections WHERE LoanId = '{loanId}'", conn);
                    int res = cmd.ExecuteNonQuery();
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


    }
}
