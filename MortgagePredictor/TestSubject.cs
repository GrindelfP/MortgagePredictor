namespace MortgagePredictor
{
    internal class TestSubject
    {
        public bool HasAnApartment { get; set; }
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

        public TestSubject(Mortgage mortgage, BankDeposit bankDeposit)
        {
            HasAnApartment = false;
            Mortgage = mortgage;
            BankDeposit = bankDeposit;
        }
    }
}
