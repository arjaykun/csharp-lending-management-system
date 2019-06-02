using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class Borrowers
    {
        private DataTable dt = new DataTable();
        private SQLiteDataAdapter da;
        private SQLiteCommand cmd;

        public string msg = "";

        public async Task<bool> Add(BorrowerModel b)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string year = Convert.ToString(DateTime.Now.Year);
                    string query = "INSERT INTO Borrowers (FirstName, LastName, MiddleName, Address, ContactNumber, Birthday," +
                        "Occupation, MonthlySalary, Image, Gender, CivilStatus, Prefix) " +
                        $"VALUES('{b.FirstName}','{b.LastName}','{b.MiddleName}','{b.Address}','{b.ContactNumber}','{b.Birthday}','{b.Occupation}','{b.MonthlySalary}'," +
                        $"'{b.Image}', '{b.Gender}', '{b.CivilStatus}', '{year}')";
                    cmd = new SQLiteCommand(query, conn);
                    int result = await cmd.ExecuteNonQueryAsync();

                    if (result > 0)
                    {
                        msg = "New Borrower is Added Successfully!";
                        return true;
                    }
                    else
                    {
                        msg = "Failed to Add New Borrower! Please try again.";
                    }
                }

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public async Task<bool> Update(BorrowerModel b)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string year = Convert.ToString(DateTime.Now.Year);
                    string query = $"UPDATE Borrowers SET Firstname = '{b.FirstName}', LastName = '{b.LastName}', " +
                        $"MiddleName = '{b.MiddleName}', Address = '{b.Address}', ContactNumber = '{b.ContactNumber}', Gender = '{b.Gender}'," +
                        $"CivilStatus = '{b.CivilStatus}', Birthday ='{b.Birthday}' ,Occupation = '{b.Occupation}', MonthlySalary = '{b.MonthlySalary}', Image = '{b.Image}' " +
                        $"WHERE Id = '{b.Id}'";
                    cmd = new SQLiteCommand(query, conn);
                    int result = await cmd.ExecuteNonQueryAsync();

                    if (result > 0)
                    {
                        msg = "Borrower is Updated Successfully!";
                        return true;
                    }
                    else
                    {
                        msg = "Failed to Update Borrower! Please try again.";
                    }
                }

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            msg = "";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    conn.Open();
                    string query = $"UPDATE Borrowers SET Status = 1 WHERE Id = '{id}';";
                    cmd = new SQLiteCommand(query, conn);
                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        msg = "Borrower is Deleted Successfully!";
                        return true;
                    }
                    else
                    {
                        msg = "Failed to Delete the Borrower! Please Try Again.";
                    }
                }

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return false;
        }

        public IEnumerable<BorrowerModel> GetAll()
        {
            List<BorrowerModel> borrowers = new List<BorrowerModel>();

            using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
            {
                dt.Clear();
                string query = "SELECT * FROM Borrowers where Status = 0";
                da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    borrowers.Add(
                        new BorrowerModel()
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            FirstName = Convert.ToString(row["FirstName"]),
                            LastName = Convert.ToString(row["LastName"]),
                            MiddleName = Convert.ToString(row["MiddleName"]),
                            ContactNumber = Convert.ToString(row["ContactNumber"]),
                            Address = Convert.ToString(row["Address"]),
                            Occupation = Convert.ToString(row["Occupation"]),
                            Birthday = Convert.ToDateTime(row["Birthday"]),
                            MonthlySalary = Convert.ToDecimal(row["MonthlySalary"]),
                            Prefix = Convert.ToString(row["Prefix"]),
                            Image = Convert.ToString(row["Image"]),
                            CivilStatus = Convert.ToString(row["CivilStatus"]),
                            Gender = Convert.ToString(row["Gender"])
                        }    
                    );
                }
            }
            return borrowers;
        }
        
        public async Task<BorrowerModel> GetSingle(int id)
        {
            BorrowerModel borrower = null;
            msg = "";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.LoadConnectionString()))
                {
                    dt.Clear();
                    conn.Open();
                    string query = $"SELECT * FROM Borrowers WHERE Id = '{id}';";
                    cmd = new SQLiteCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();
                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                    DataRow row = dt.Rows[0];

                    borrower = new BorrowerModel()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        FirstName = Convert.ToString(row["FirstName"]),
                        LastName = Convert.ToString(row["LastName"]),
                        MiddleName = Convert.ToString(row["MiddleName"]),
                        ContactNumber = Convert.ToString(row["ContactNumber"]),
                        Address = Convert.ToString(row["Address"]),
                        Occupation = Convert.ToString(row["Occupation"]),
                        Birthday = Convert.ToDateTime(row["Birthday"]),
                        MonthlySalary = Convert.ToDecimal(row["MonthlySalary"]),
                        Prefix = Convert.ToString(row["Prefix"]),
                        Image = Convert.ToString(row["Image"]),
                        CivilStatus = Convert.ToString(row["CivilStatus"]),
                        Gender = Convert.ToString(row["Gender"])
                    };
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            
            return borrower;
        }
            
        public int ComputeAge(DateTime bday)
        {
            DateTime now = DateTime.Now;

            int month = bday.Month;
            int day = bday.Day;
            int year = bday.Year;

            int age = now.Year - year;
            if (month > 12 || day > 31)
            {
                throw new FormatException();
            }

            if (day > 31 || day < 1)
            {
                throw new FormatException();
            }
            

            if (now.Month <= month )
            {
                if (now.Day < day )
                {
                    age = age - 1;
                }
            } 

            return age;
        }
    }
}
