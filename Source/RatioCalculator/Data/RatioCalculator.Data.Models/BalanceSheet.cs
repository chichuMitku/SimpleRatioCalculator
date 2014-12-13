namespace RatioCalculator.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RatioCalculator.Data.Common.Models;

    public class BalanceSheet : IFinancialStatement
    {
        [Key]
        public int Id { get; set; }

        public int FinancialReportId { get; set; }

        public virtual IFinancialReport FinancialReport { get; set; }

        // TODO: implement all fields using extended accounting model
    }
}
