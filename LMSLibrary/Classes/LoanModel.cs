using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class LoanModel : ILoanModel
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string LoanId
        {
            get
            {
                return $"{Prefix}{Id:000000}";
            }
        }

        public int BorrowerId { get; set; }
        public string BorrowerName { get; set; }
        public int CollectorId { get; set; }
        public string Collector { get; set; }
        public int Duration { get; set; }
        public decimal PrincipalLoan { get; set; }
        public int InterestId { get; set; }
        public string PaymentTerm { get; set; }
        public decimal Interest { get; set; }
        public decimal PerRemittance { get; set; }
        public decimal MaturityValue { get; set; }
        public decimal TotalBalance { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public GuarantorModel Guarantor { get; set; }
        public CollateralModel Collateral { get; set; }
     
    }
}
