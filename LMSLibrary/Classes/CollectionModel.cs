using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class CollectionModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int BorrowerId { get; set; }
        public int LoanId { get; set; }
        public LoanModel Loan { get; set; }
        public BorrowerModel Borrower { get; set; }
        public DateTime Date { get; set; }


        public string Date2 {
            get
            {
               return  Date.ToShortDateString();
            }
        }
        public string BorrowerName {
            get
            {
                return Borrower.FullName;
            }
        }
        public string InterestCollected
        {
            get
            {
                return $"P{(Loan.Interest / Loan.Duration):0.00}";
            }
        }

        public string Amount2
        {
            get
            {
                return $"P{Amount:0.00}";
            }
        }
        public string LoanId2
        {
            get
            {
                return Loan.LoanId;
            }
        }

        public string CollectorName
        {
            get
            {
                return Loan.Collector;
            }
        }

    }
}
