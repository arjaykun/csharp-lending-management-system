using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
   public class BorrowerModel
   {
        public int Id { get; set; }
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Occupation { get; set; }
        public decimal MonthlySalary { get; set; }
        public string Prefix { get; set; }
        public string BorrowerID
        {
            get
            {
                return $"{Prefix}{Id:000000}";
            }
        }
        public string FullName {
            get
            {
                string output = "";
                try
                {
                    output = $"{LastName}, {FirstName} {MiddleName[0]}.";
                }
                catch (Exception)
                {
                    return "There's No Borrowers Available in Database Yet!";
                }
                return output;
            }
        }
    }
}
