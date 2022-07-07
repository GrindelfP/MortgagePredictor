namespace MortgagePredictor
{
    internal class ResultData
    {
        internal double DebetAcountBalance { get; set; }
        internal int MonthNumber { get; set; }
        internal bool HasAnApartment { get; set; }
        public ResultData()
        {
            DebetAcountBalance = 0;
            MonthNumber = 0;
            HasAnApartment = false;
        }
        public ResultData(double debetAcountBalance, int monthNumber, bool hasAnApartment)
        {
            DebetAcountBalance = debetAcountBalance;
            MonthNumber = monthNumber;
            HasAnApartment = hasAnApartment;
        }
    }
}
