namespace RatioCalculator.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using RatioCalculator.Data.Common.Repository;
    using RatioCalculator.Data.Models;

    public class RatioCalculatorData : RatioCalculator.Data.IRatioCalculatorData
    {
        private readonly DbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public RatioCalculatorData(DbContext context)
        {
            this.context = context;
        }

        public IRepository<BalanceSheet> BalanceSheets
        {
            get
            {
                return GetRepository<BalanceSheet>();
            }
        }

        public IRepository<Comment> Comments
        {
            get
            {
                return GetRepository<Comment>();
            }
        }

        public IRepository<FinancialReport> FinancialReports
        {
            get
            {
                return GetRepository<FinancialReport>();
            }
        }

        public IRepository<FinancialStatementItem> FinancialStatementItems
        {
            get
            {
                return GetRepository<FinancialStatementItem>();
            }
        }

        public IRepository<ProfitLossStatement> ProfitLossStatements
        {
            get
            {
                return GetRepository<ProfitLossStatement>();
            }
        }

        public IRepository<User> Users
        {
            get
            {
                return GetRepository<User>();
            }
        }

        public DbContext Context
        {
            get { return this.context; }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
