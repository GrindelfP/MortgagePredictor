using System.Collections.Generic;

namespace MortgagePredictor
{
    internal class Simulation
    {
        private List<TestSubject> testSubjects;

        public Simulation(double apartmentCost, double rentAmount, FreeMoney freeMoney, Mortgage mortgage, BankDeposit bankDeposit)
        {
            testSubjects = new List<TestSubject>();
            for (var i = 0; i < 11; i++) testSubjects.Add(new TestSubject(apartmentCost, rentAmount, freeMoney, mortgage, bankDeposit));
        }
    }
}
