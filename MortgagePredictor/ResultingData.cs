namespace MortgagePredictor
{
    internal class ResultData
    {
        internal double DebetAccountBalance { get; set; }
        internal int MonthNumber { get; set; }
        internal bool HasApartment { get; set; }
        public ResultData()
        {
            DebetAccountBalance = 0;
            MonthNumber = 0;
            HasApartment = false;
        }
    }
}
