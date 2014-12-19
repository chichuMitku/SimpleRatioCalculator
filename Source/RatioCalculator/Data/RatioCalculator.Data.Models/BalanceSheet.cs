namespace RatioCalculator.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using RatioCalculator.Data.Common.Models;

    public class BalanceSheet : IFinancialStatement
    {
        private ICollection<BalanceSheetItem> balanceSheetItems;

        public BalanceSheet()
        {
            this.balanceSheetItems = new HashSet<BalanceSheetItem>();
        }

        [Key, ForeignKey("FinancialReport")]
        public int FinancialReportId { get; set; }

        public virtual FinancialReport FinancialReport { get; set; }

        public ICollection<BalanceSheetItem> BalanceSheetItems 
        {
            get { return this.balanceSheetItems; }
            set { this.balanceSheetItems = value; }
        }

        // TODO: implement all fields using extended accounting model
    }
}
