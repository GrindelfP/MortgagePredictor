namespace MortgagePredictor
{
    internal class TestSubject
    {
        public bool HasAnApartment { get; set; }
        public Mortgage Mortgage { get; }
        public BankDeposit BankDeposit { get; } 

        public TestSubject(Mortgage mortgage, BankDeposit bankDeposit)
        {
            HasAnApartment = false;
            Mortgage = mortgage;
            BankDeposit = bankDeposit;
        }
    }
}
