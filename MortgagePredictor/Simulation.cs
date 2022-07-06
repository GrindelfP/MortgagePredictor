using System.Collections.Generic;

namespace MortgagePredictor
{
    internal class Simulation
    {
        private readonly double _apartmentCost;
        private readonly double _rentAmount;
        private readonly double _freeMoney;
        private readonly List<TestSubject> _testSubjectsGroup;

        public List<List<ResultData>> Simulate(int numberOfMonths)
        {
            var theResult = new List<List<ResultData>>();

            // Simulation of Instant Mortgage Taker
            theResult[0] = SimulateInstantMortgageTaker(numberOfMonths);

            // Simulation of Delayed Mortgage Taker
            for (var i = 1; i < _testSubjectsGroup.Count - 1; i++) theResult[i] = SimulateDelayedMortgageTaker(numberOfMonths, i);

            // Simulation of No Mortgage Taker
            theResult[_testSubjectsGroup.Count - 1] = SimulateNoMortgageTaker(numberOfMonths);

            return theResult;
        }

        private List<ResultData> SimulateInstantMortgageTaker(int numberOfMonths)
        {
            var resultingData = new List<ResultData>();
            var subject = _testSubjectsGroup[0];
            subject.Mortgage.Amount = _apartmentCost;
            for (var i = 0; i < numberOfMonths; i++)
            {
                if (subject.Mortgage.Amount != 0) PayMortgage(subject);
                else subject.BankDeposit.IncreaseBalance(_freeMoney);
                subject.BankDeposit.AddMonthlyInterest();
                resultingData[i] = new ResultData(subject.BankDeposit.Balance, i + 1);
            }
                        
            return resultingData;
        }
        private List<ResultData> SimulateDelayedMortgageTaker(int numberOfMonths, int stepOfDelay)
        {
            var resultingData = new List<ResultData>();
            var subject = _testSubjectsGroup[stepOfDelay];
            for (var i = 0; i < numberOfMonths; i++)
            {
                if (subject.BankDeposit.Balance > _apartmentCost * stepOfDelay * 0.1 && subject.HasAnApartment == false)
                {
                    subject.Mortgage.Amount = _apartmentCost - subject.BankDeposit.Balance;
                    subject.BankDeposit.DecreaseBalance(_apartmentCost * stepOfDelay * 0.1);
                    subject.HasAnApartment = true;
                }
                if (subject.Mortgage.Amount != 0) PayMortgage(subject);
                else subject.BankDeposit.IncreaseBalance(_freeMoney);
                subject.BankDeposit.AddMonthlyInterest();
                resultingData[i] = new ResultData(subject.BankDeposit.Balance, i + 1);
            }

            return resultingData;
        }
        
        private List<ResultData> SimulateNoMortgageTaker(int numberOfMonths)
        {
            var resultingData = new List<ResultData>();
            var subject = _testSubjectsGroup[_testSubjectsGroup.Count - 1];
            for (var i = 0; i < numberOfMonths; i++)
            {
                if (subject.BankDeposit.Balance > _apartmentCost && subject.HasAnApartment == false) 
                {
                    subject.BankDeposit.DecreaseBalance(_apartmentCost);
                    subject.HasAnApartment = true;
                } 
                if (!subject.HasAnApartment) subject.BankDeposit.IncreaseBalance(_freeMoney - _rentAmount);
                else subject.BankDeposit.IncreaseBalance(_freeMoney);
                subject.BankDeposit.AddMonthlyInterest();
                resultingData[i] = new ResultData(subject.BankDeposit.Balance, i + 1);
            }

            return resultingData;
        }

        private void PayMortgage(TestSubject subject)
        {
            subject.Mortgage.DecreaseMortgage(_freeMoney);
            if (subject.Mortgage.Amount < 0)
            {
                subject.BankDeposit.IncreaseBalance(-subject.Mortgage.Amount);
                subject.Mortgage.Amount = 0;
            }
        }

        private List<TestSubject> InitializeTestSubjectsGroup(double mortgagePercentage, double debetPercentage)
        {
            var testSubjectsGroup = new List<TestSubject>();
            for (var i = 0; i < 11; i++) testSubjectsGroup.Add(new TestSubject(new Mortgage(0, mortgagePercentage), new BankDeposit(0, debetPercentage)));
            return testSubjectsGroup;
        }

        public Simulation(double apartmentCost, double rentAmount, double freeMoney, double mortgagePercentage, double debetPercentage)
        {
            _apartmentCost = apartmentCost;
            _rentAmount = rentAmount;
            _freeMoney = freeMoney;
            _testSubjectsGroup = InitializeTestSubjectsGroup(mortgagePercentage, debetPercentage);
        }
    }
}
