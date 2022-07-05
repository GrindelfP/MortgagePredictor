namespace MortgagePredictor
{
    internal class TestSubject
    {
        public double ApartmentCost { get; }
        public double RentAmount { get; }
        public FreeMoney FreeMoney { get; }
        public Mortgage Mortgage { get; }
        public BankDeposit BankDeposit { get; } 

        public TestSubject(double apartmentCost, double rentAmount, FreeMoney freeMoney, Mortgage mortgage, BankDeposit bankDeposit)
        {
            ApartmentCost = apartmentCost;
            RentAmount = rentAmount;
            FreeMoney = freeMoney;
            Mortgage = mortgage;
            BankDeposit = bankDeposit;
        }
    }
}
