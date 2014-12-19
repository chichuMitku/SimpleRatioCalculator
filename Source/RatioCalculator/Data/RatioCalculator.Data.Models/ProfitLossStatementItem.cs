namespace RatioCalculator.Data.Models
{
    public class ProfitLossStatementItem : FinancialStatementItem
    {
        public int ProfitLossStatementId { get; set; }

        public virtual ProfitLossStatement ProfitLossStatement { get; set; }
    }
}
