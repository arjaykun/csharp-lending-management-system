using LMSLibrary.Classes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending_Management_System
{
    public partial class frmPrintReceipt : Form
    {
        public List<LedgerModel> Ledger;
        public string principalLoan, loanId, borrower, collector, maturityValue, 
            effectiveDate, maturityDate, totalBalance;

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            using (frmNewLoan frm = new frmNewLoan())
            {
                frm.ShowDialog();
            }
        }
        
        public frmPrintReceipt()
        {
            InitializeComponent();
            
        }

        private void frmPrintReceipt_Load(object sender, EventArgs e)
        {
            LedgerModelBindingSource.DataSource = Ledger;
            ReportParameter[] para = new ReportParameter[] {
                new ReportParameter("LoanId", loanId),
                new ReportParameter("PrincipalLoan", principalLoan),
                new ReportParameter("Borrower", borrower),
                new ReportParameter("Collector", collector),
                new ReportParameter("MaturityValue", maturityValue),
                new ReportParameter("EffectiveDate", effectiveDate),
                new ReportParameter("MaturityDate", maturityDate),
                new ReportParameter("TotalBalance", totalBalance)

            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
