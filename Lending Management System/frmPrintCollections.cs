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
    public partial class frmPrintCollections : Form
    {
        public IEnumerable<CollectionModel> collections;
        public string totalCollection, totalInterest, date;
        public frmPrintCollections(string totalCol, string totalInt, string _date)
        {
            InitializeComponent();
            totalCollection = totalCol;
            totalInterest = totalInt;
            date = _date;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPrintCollections_Load(object sender, EventArgs e)
        {
            CollectionModelBindingSource.DataSource = collections;
            ReportParameter[] para = new ReportParameter[] {
                new ReportParameter("date", date),
                new ReportParameter("totalcollection", totalCollection),
                new ReportParameter("totalinterest", totalInterest)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
