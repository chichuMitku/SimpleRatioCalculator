namespace RatioCalculator.Data.Models
{
    public class BalanceSheetItem : FinancialStatementItem
    {
        public int BalanceSheetId { get; set; }

        public virtual BalanceSheet BalanceSheet { get; set; }
    }
}
