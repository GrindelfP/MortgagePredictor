namespace MortgagePredictor
{
    internal class BankDeposit
    {
        public double Balance { get; set; }
        public double Percentage { get; set; }
        public double AddMonthlyInterest()
        {
            Balance += Balance* Percentage / 12.0;
            return Balance;
        }

        public double IncreaseBalance(double increment) 
        {
            Balance += increment;
            return Balance;
        } 
        public double DecreaseBalance(double decrement) 
        {
            Balance -= decrement;
            return Balance;
        }
        public BankDeposit(double balance, double percentage)
        {
            Balance = balance;
            Percentage = percentage;
        }
    }
}
