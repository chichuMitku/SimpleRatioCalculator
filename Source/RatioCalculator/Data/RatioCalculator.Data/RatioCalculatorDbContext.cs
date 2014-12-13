namespace RatioCalculator.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Microsoft.AspNet.Identity.EntityFramework;

    using RatioCalculator.Data.Common.Models;
    using RatioCalculator.Data.Models;

    public class RatioCalculatorDbContext : IdentityDbContext<User>
    {
        public RatioCalculatorDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<BalanceSheet> BalanceSheets { get; set; }

        public IDbSet<ProfitLossStatement> ProfitLossStatements { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<FinancialReport> FinancialReports { get; set; }

        public IDbSet<FinancialStatementItem> FinancialStatementItems { get; set; }

        public static RatioCalculatorDbContext Create()
        {
            return new RatioCalculatorDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    if (!entity.PreserveCreatedOn)
                    {
                        entity.CreatedOn = DateTime.Now;
                    }
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }


}
