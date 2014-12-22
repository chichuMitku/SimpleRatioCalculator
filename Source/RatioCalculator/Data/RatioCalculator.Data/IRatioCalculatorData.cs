namespace RatioCalculator.Data
{
    using RatioCalculator.Data.Common.Repository;
    using RatioCalculator.Data.Models;
    using System;
    using System.Data.Entity;

    public interface IRatioCalculatorData
    {
        DbContext Context { get; }

        IRepository<BalanceSheet> BalanceSheets { get; }

        IRepository<Comment> Comments { get; }

        IRepository<FinancialReport> FinancialReports { get; }

        IRepository<FinancialStatementItem> FinancialStatementItems { get; }

        IRepository<User> Users { get; }

        IRepository<ProfitLossStatement> ProfitLossStatements { get; }

        void Dispose();

        int SaveChanges();
    }
}
