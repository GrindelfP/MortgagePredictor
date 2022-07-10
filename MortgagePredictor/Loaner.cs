namespace MortgagePredictor
{
    internal class Loaner
    {
        public bool HasApartment { get; set; }
        public Mortgage Mortgage { get; }
        public BankDeposit BankDeposit { get; }

        public void PayMortgage(double decrement)
        {
            Mortgage.DecreaseMortgage(decrement);
            if (Mortgage.Amount < 0)
            {
                BankDeposit.IncreaseBalance(-Mortgage.Amount);
                Mortgage.Amount = 0;
            }
        }

        public Loaner(Mortgage mortgage, BankDeposit bankDeposit)
        {
            HasApartment = false;
            Mortgage = mortgage;
            BankDeposit = bankDeposit;
        }
    }
}
