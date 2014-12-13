namespace RatioCalculator.Data.Models
{
    using RatioCalculator.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class FinancialReport : IFinancialReport, IAuditInfo, IDeletableEntity
    {
        private ICollection<Comment> comments;

        public FinancialReport()
        {
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        [Index]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string CompanyName { get; set; }

        public virtual ICollection<Comment> Comments 
        {
            get { return this.comments; }
            set { this.comments = value; } 
        }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int PeriodInMonths { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int BalanceSheetId { get; set; }

        public virtual IFinancialStatement BalanceSheet { get; set; }

        public int ProfitLossStatementId { get; set; }

        public virtual IFinancialStatement ProfitLossStatement { get; set; }

    }
}
