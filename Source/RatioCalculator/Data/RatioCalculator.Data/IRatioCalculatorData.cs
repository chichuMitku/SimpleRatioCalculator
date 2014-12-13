namespace RatioCalculator.Data
{
    using RatioCalculator.Data.Common.Repository;
    using RatioCalculator.Data.Models;
    using System;
    using System.Data.Entity;

    public interface IRatioCalculatorData
    {
        IRepository<BalanceSheet> BalanceSheets { get; }

        IRepository<Comment> Comments { get; }

        DbContext Context { get; }

        void Dispose();

        IRepository<FinancialReport> FinancialReports { get; }

        IRepository<FinancialStatementItem> FinancialStatementItems { get; }

        IRepository<ProfitLossStatement> ProfitLossStatements { get; }

        int SaveChanges();

        IRepository<User> Users { get; }
    }
}
