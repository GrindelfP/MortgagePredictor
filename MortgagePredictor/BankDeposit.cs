namespace MortgagePredictor
{
    internal class BankDeposit
    {
        public double Balance { get; }
        public double Percentage { get; }
        public double IncreaseUsingPercentsMontly() => Balance + Balance * Percentage / 12.0;
        public double IncreaseBalance(double increment) => Balance + increment; 
        public double DecreaseBalance(double decrement) => Balance - decrement; 
        
        public BankDeposit(int balance, int percentage)
        {
            Balance = balance;
            Percentage = percentage;
        }
    }
}
