using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class Loans
    {
        private SQLiteCommand cmd;
        private SQLiteDataAdapter da;
        public string msg = "";
        private DataTable dt = new DataTable();
        public int loanId = 0;

        public async Task<bool> Add(ILoanModel l, GuarantorModel g, CollateralModel c)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string year = Convert.ToString(DateTime.Now.Year);
                    string query = "INSERT INTO Loans (BorrowerId, CollectorId, PrincipalLoan, InterestId, Interest, MaturityValue," +
                        "PerRemittance, Duration, EffectiveDate, MaturityDate,TotalBalance, Prefix) " +
                        $"VALUES('{l.BorrowerId}','{l.CollectorId}','{l.PrincipalLoan}','{l.InterestId}','{l.Interest}','{l.MaturityValue}','{l.PerRemittance}','{l.Duration}'," +
                        $"'{l.EffectiveDate.ToShortDateString()}', '{l.MaturityDate.ToShortDateString()}', '{l.TotalBalance}', '{year}')";
                    cmd = new SQLiteCommand(query, conn);
                    int result = await cmd.ExecuteNonQueryAsync();

                    if (result > 0)
                    {
                        cmd = new SQLiteCommand("SELECT last_insert_rowid()", conn);
                        Int64 id = Convert.ToInt64(await cmd.ExecuteScalarAsync());
                        int _loanId = (int)id;
                        loanId = _loanId;

                        if(await AddCollateral(c, _loanId) && await AddGuarantor(g, loanId))
                        {
                            msg = "New Loan is Added Successfully!";
                            return true;
                        }
                        else
                            msg = "Failed to add collateral and guarantor";
                    }
                    else
                    {
                        msg = "Failed to Add New Loan! Please try again.";
                    }
                }

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public async Task<bool> Update(ILoanModel l, GuarantorModel g, CollateralModel c)
        {
            try
            { 
              if (await UpdateCollateral(c, l.Id) && await UpdateGuarantor(g, l.Id))
              {
                 msg = "Loan is Updated Successfully!";
                 return true;
              }
                msg = "Failed To Update Loan";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public async Task<IEnumerable<ILoanModel>> GetAll()
        {
            List<LoanModel> loans = new List<LoanModel>();
            try
            { using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                string query = "SELECT * FROM (((Loans as l LEFT JOIN Borrowers as b ON l.BorrowerId = b.Id) " + 
                        "LEFT JOIN Interests as i ON l.InterestId = i.Id) LEFT JOIN Users as u ON l.CollectorId = u.Id);";
                conn.Open();
                cmd = new SQLiteCommand(query, conn);
                await cmd.ExecuteNonQueryAsync();
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
               
                foreach (DataRow row in dt.Rows)
                {
                    loans.Add(new LoanModel() {
                        Id = Convert.ToInt32(row["id"]),
                        PrincipalLoan = Convert.ToDecimal(row["PrincipalLoan"]),
                        PerRemittance = Convert.ToDecimal(row["PerRemittance"]),
                        Interest = Convert.ToDecimal(row["Interest"]),
                        BorrowerName= Convert.ToString(row["LastName"] + ", " + row["FirstName"] + " ") + Convert.ToString(row["MiddleName"])[0] + ".",
                        Collector = Convert.ToString(row["Name"]),
                        PaymentTerm = Convert.ToString(row["Description"]),
                        MaturityValue = Convert.ToDecimal(row["MaturityValue"]),
                        Duration = Convert.ToInt32(row["Duration"]),
                        EffectiveDate = Convert.ToDateTime(row["EffectiveDate"]),
                        MaturityDate = Convert.ToDateTime(row["MaturityDate"]),
                        TotalBalance = Convert.ToDecimal(row["TotalBalance"]),
                        Prefix = Convert.ToString(row["Prefix"])
                    });
                }
            }

            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return loans;
        }

        public async Task<LoanModel> GetSingle(int loanId, int borrowerId = 0)
        {
            dt.Clear();
            LoanModel loan = new LoanModel();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    string query = "";
                    if (borrowerId != 0)
                        query = $"SELECT * FROM Loans WHERE BorrowerId = '{borrowerId}';";
                    else
                        query = $"SELECT * FROM Loans WHERE Id = '{loanId}';";

                    conn.Open();
                    cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();
                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];
                    Users users = new Users();
                    loan.Id = Convert.ToInt32(row["Id"]);
                    loan.BorrowerId = Convert.ToInt32(row["BorrowerId"]);
                    loan.CollectorId = Convert.ToInt32(row["CollectorId"]);
                    loan.PrincipalLoan = Convert.ToDecimal(row["PrincipalLoan"]);
                    loan.Interest = Convert.ToDecimal(row["Interest"]);
                    loan.InterestId = Convert.ToInt32(row["InterestId"]);
                    loan.PerRemittance = Convert.ToDecimal(row["PerRemittance"]);
                    loan.MaturityValue = Convert.ToDecimal(row["MaturityValue"]);
                    loan.Duration = Convert.ToInt32(row["Duration"]);
                    loan.EffectiveDate = Convert.ToDateTime(row["EffectiveDate"]);
                    loan.MaturityDate = Convert.ToDateTime(row["MaturityDate"]);
                    loan.TotalBalance = Convert.ToDecimal(row["TotalBalance"]);
                    loan.Prefix = Convert.ToString(row["Prefix"]);
                    loan.Guarantor = await GetGuarantor(loan.Id);
                    loan.Collateral = await GetColleteral(loan.Id);
                    UserModel u = users.GetSingle("", loan.CollectorId);
                    loan.Collector = u.Name;
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }

            return loan;
        }

        public int IfHasLoan(int borrowerId)
        {
            dt.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                da = new SQLiteDataAdapter($"SELECT * FROM Loans WHERE BorrowerId = '{borrowerId}'  ORDER BY Id DESC;", conn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    decimal balance = Convert.ToDecimal(row["TotalBalance"]);
                    if ( balance > 0)
                    {
                        return Convert.ToInt32(dt.Rows[0]["Id"]);
                    }
                }
            }
            return 0;
        }

        public async Task<bool> Delete(int loanId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    cmd = new SQLiteCommand($"DELETE FROM Loans WHERE Id = '{loanId}'", conn);
                    int res = await cmd.ExecuteNonQueryAsync();
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
       
        public async Task<GuarantorModel> GetGuarantor(int id)
        {
            dt.Clear();
            GuarantorModel guarantor = new GuarantorModel();
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                string query = $"SELECT * FROM Guarantors WHERE LoanId = '{id}';";
                conn.Open();
                cmd = new SQLiteCommand(query, conn);
                await cmd.ExecuteNonQueryAsync();
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                DataRow g = dt.Rows[0];
                guarantor.Id = Convert.ToInt32(g["Id"]);
                guarantor.Name = Convert.ToString(g["Name"]);
                guarantor.Address = Convert.ToString(g["Address"]);
                guarantor.ContactNumber = Convert.ToString(g["ContactNumber"]);
                guarantor.Relationship = Convert.ToString(g["Relation"]);
            }

            return guarantor;
        }

        public async Task<bool> AddGuarantor(GuarantorModel g, int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    cmd = new SQLiteCommand("INSERT INTO Guarantors (LoanId, Name, Relation, ContactNumber, Address) " +
                            $"VALUES('{id}', '{g.Name}','{g.Relationship}','{g.ContactNumber}','{g.Address}');",conn);
                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                        return true;
                    else
                        msg = "Failed to add Guarantor";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public async Task<bool> UpdateGuarantor(GuarantorModel g, int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    cmd = new SQLiteCommand($"UPDATE Guarantors  SET Name = '{g.Name}' , Relation = '{g.Relationship}', ContactNumber = '{g.ContactNumber}', " +
                        $"Address = '{g.Address}' WHERE LoanId = '{id}';", conn);
                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                        return true;
                    else
                        msg = "Failed to update Guarantor";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }
        public async Task<CollateralModel> GetColleteral(int id)
        {
            dt.Clear();
            CollateralModel collateral = new CollateralModel();
            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                string query = $"SELECT * FROM Collaterals WHERE LoanId = '{id}';";
                conn.Open();
                cmd = new SQLiteCommand(query, conn);
                await cmd.ExecuteNonQueryAsync();
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
  
                DataRow c = dt.Rows[0];
                collateral.Id = Convert.ToInt32(c["Id"]);
                collateral.Item= Convert.ToString(c["Item"]);
                collateral.Description = Convert.ToString(c["Description"]);
                collateral.Value = Convert.ToDecimal(c["Value"]);
            }

            return collateral;
        }
        public async Task<bool> AddCollateral(CollateralModel c, int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    cmd = new SQLiteCommand("INSERT INTO Collaterals (LoanId, Item, Value, Description)" +
                    $"VALUES('{id}', '{c.Item}','{c.Value}','{c.Description}')", conn);
                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                        return true;
                    else
                        msg = "Failed to add Collateral";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public async Task<bool> UpdateCollateral(CollateralModel c, int id)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    cmd = new SQLiteCommand($"UPDATE Collaterals SET Item = '{c.Item}', Value ='{c.Value}', Description = '{c.Description}'" +
                    $" WHERE LoanId = '{id}'", conn);
                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                        return true;
                    else
                        msg = "Failed to update Collateral";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public async Task<bool> UpdateBalance(int id, decimal newBalance)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = $"UPDATE Loans SET TotalBalance = '{newBalance}' WHERE Id = '{id}'";
                    cmd = new SQLiteCommand(query, conn);
                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                        return true;
                    else
                        msg = "Failed to update Total Balance!";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }


    }
}
