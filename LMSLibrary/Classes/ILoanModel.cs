using System;

namespace LMSLibrary.Classes
{
    public interface ILoanModel
    {
        int BorrowerId { get; set; }
        int CollectorId { get; set; }
        int Duration { get; set; }
        DateTime EffectiveDate { get; set; }
        int Id { get; set; }
        decimal Interest { get; set; }
        int InterestId { get; set; }
        string LoanId { get; }
        DateTime MaturityDate { get; set; }
        decimal MaturityValue { get; set; }
        decimal PerRemittance { get; set; }
        string Prefix { get; set; }
        decimal PrincipalLoan { get; set; }
        string Collector { get; set; }
        string PaymentTerm { get; set; }
        decimal TotalBalance { get; set; }
    }
}