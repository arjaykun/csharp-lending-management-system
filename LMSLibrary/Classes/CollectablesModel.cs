using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class CollectablesModel
    {
        public int Id { get; set; }
        public LoanModel Loan { get; set; }
        public BorrowerModel Borrower { get; set; }
        public DateTime DueDate { get; set; }
    }
}
