namespace MortgagePredictor
{
    internal class Mortgage
    {
        public double Amount { get; set; }
        public double Percentage { get; }
        public double DecreaseMortgage(double fullDecrement) => Amount - (fullDecrement - Amount * Percentage / 12);
        public Mortgage(double amount, double percentage)
        {
            Amount = amount;
            Percentage = percentage;
        }
    }
}
