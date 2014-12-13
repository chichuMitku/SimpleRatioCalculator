namespace RatioCalculator.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public int FinancialReportId { get; set; }

        public virtual FinancialReport FinancialReport { get; set; }


    }
}
