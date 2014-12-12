namespace RatioCalculator.Data.Models
{
    using RatioCalculator.Data.Common.Models;
    using System.ComponentModel.DataAnnotations;

    public class BalanceSheet : IFinancialStatement
    {
        [Key]
        public int Id { get; set; }

        public int FinancialReportId { get; set; }

        public virtual IFinancialReport FinancialReport { get; set; }

        // TODO: implement all fields using extended accounting model
    }
}
