namespace MortgagePredictor
{
    internal class ResultData
    {
        internal double DebetAcountBalance { get; set; }
        internal int MonthNumber { get; set; }
        public ResultData()
        {
            DebetAcountBalance = 0;
            MonthNumber = 0;
        }
        public ResultData(double debetAcountBalance, int monthNumber)
        {
            DebetAcountBalance = debetAcountBalance;
            MonthNumber = monthNumber;
        }
    }
}
