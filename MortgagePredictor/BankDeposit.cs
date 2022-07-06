namespace MortgagePredictor
{
    internal class BankDeposit
    {
        public double Balance { get; }
        public double Percentage { get; }
        public double AddMonthlyInterest() => Balance + Balance * Percentage / 12.0;
        public double IncreaseBalance(double increment) => Balance + increment; 
        public double DecreaseBalance(double decrement) => Balance - decrement; 
        
        public BankDeposit(double balance, double percentage)
        {
            Balance = balance;
            Percentage = percentage;
        }
    }
}
