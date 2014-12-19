namespace RatioCalculator.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using RatioCalculator.Data.Common.Models;

    public class ProfitLossStatement : IFinancialStatement
    {
        private ICollection<ProfitLossStatementItem> profitLossStatementItems;

        public ProfitLossStatement()
        {
            this.profitLossStatementItems = new HashSet<ProfitLossStatementItem>();
        }
        
        [Key, ForeignKey("FinancialReport")]
        public int FinancialReportId { get; set; }

        public virtual FinancialReport FinancialReport { get; set; }

        public ICollection<ProfitLossStatementItem> ProfitLossStatementItems
        {
            get { return this.profitLossStatementItems; }
            set { this.profitLossStatementItems = value; }
        }

        // TODO: implement all fields using extended accounting model
    }
}
