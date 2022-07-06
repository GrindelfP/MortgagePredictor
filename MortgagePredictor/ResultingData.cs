namespace MortgagePredictor
{
    internal struct ResultData
    {
        internal double DebetAcountBalance { get; }
        internal int MonthNumber { get; }
        public ResultData(double debetAcountBalance, int monthNumber)
        {
            DebetAcountBalance = debetAcountBalance;
            MonthNumber = monthNumber;
        }
    }
}
