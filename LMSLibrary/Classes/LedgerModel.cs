using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSLibrary.Classes
{
    public class LedgerModel
    {
        public string DueDate { get; set; }
        public string Amount { get; set; }
        public string Interest { get; set; }
        public string TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
