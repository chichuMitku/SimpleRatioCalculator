namespace RatioCalculator.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RatioCalculator.Data.Common.Models;

    public class FinancialStatementItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Description { get; set; }

        [Required]
        public int FinancialStatementId { get; set; }

        public virtual IFinancialStatement Statement { get; set; }

        public int? CurrentPeriodValue { get; set; }

        public int? PreviousPeriodValue { get; set; }
    }
}
