using System.Collections.Generic;

namespace MortgagePredictor
{
    internal class Simulation
    {
        private readonly double _apartmentCost;
        private readonly double _rentAmount;
        private readonly double _freeMoney;
        private const double Partition = 0.1;
        private readonly List<Loaner> _testSubjectsGroup;

        public List<List<ResultData>> ProcessSimulation(int numberOfMonths)
        {
            var simulationResult = new List<List<ResultData>>();
            for (var i = 0; i < _testSubjectsGroup.Count; i++) simulationResult.Add(new List<ResultData>());

            // Simulation of Instant Mortgage Taker
            simulationResult[0] = SimulateInstantMortgageTaker(numberOfMonths);

            // Simulation of Delayed Mortgage Taker
            for (var i = 1; i < _testSubjectsGroup.Count - 1; i++) simulationResult[i] = SimulateDelayedMortgageTaker(numberOfMonths, i);

            // Simulation of No Mortgage Taker
            simulationResult[_testSubjectsGroup.Count - 1] = SimulateNoMortgageTaker(numberOfMonths);

            return simulationResult;
        }

        private List<ResultData> SimulateInstantMortgageTaker(int numberOfMonths)
        {
            var resultingData = new List<ResultData>();
            for (var i = 0; i < numberOfMonths; i++) resultingData.Add(new ResultData());
            var subject = _testSubjectsGroup[0];
            subject.Mortgage.Amount = _apartmentCost;
            subject.HasApartment = true;
            for (var i = 0; i < numberOfMonths; i++)
            {
                if (subject.Mortgage.Amount != 0) subject.PayMortgage(_freeMoney);
                else subject.BankDeposit.IncreaseBalance(_freeMoney);
                subject.BankDeposit.AddMonthlyInterest();
                resultingData[i].DebetAccountBalance = subject.BankDeposit.Balance;
                resultingData[i].MonthNumber = i + 1;
                resultingData[i].HasApartment = subject.HasApartment;
            }
                        
            return resultingData;
        }
        private List<ResultData> SimulateDelayedMortgageTaker(int numberOfMonths, int stepOfDelay)
        {
            var resultingData = new List<ResultData>();
            for (var i = 0; i < numberOfMonths; i++) resultingData.Add(new ResultData());
            var subject = _testSubjectsGroup[stepOfDelay];
            var depositAmount = DepositAmount(stepOfDelay);
            for (var i = 0; i < numberOfMonths; i++)
            {
                if (subject.BankDeposit.Balance >= depositAmount && !subject.HasApartment)
                {
                    subject.Mortgage.Amount = _apartmentCost - depositAmount;
                    subject.BankDeposit.DecreaseBalance(depositAmount);
                    subject.HasApartment = true;
                }
                if (subject.Mortgage.Amount != 0) subject.PayMortgage(_freeMoney);
                else if (!subject.HasApartment) subject.BankDeposit.IncreaseBalance(_freeMoney - _rentAmount);
                else subject.BankDeposit.IncreaseBalance(_freeMoney);
                subject.BankDeposit.AddMonthlyInterest();
                resultingData[i].DebetAccountBalance = subject.BankDeposit.Balance;
                resultingData[i].MonthNumber = i + 1;
                resultingData[i].HasApartment = subject.HasApartment;
            }

            return resultingData;
        }
        
        private List<ResultData> SimulateNoMortgageTaker(int numberOfMonths)
        {
            var resultingData = new List<ResultData>();
            for (var i = 0; i < numberOfMonths; i++) resultingData.Add(new ResultData());
            var subject = _testSubjectsGroup[_testSubjectsGroup.Count - 1];
            for (var i = 0; i < numberOfMonths; i++)
            {
                if (subject.BankDeposit.Balance >= _apartmentCost && !subject.HasApartment) 
                {
                    subject.BankDeposit.DecreaseBalance(_apartmentCost);
                    subject.HasApartment = true;
                } 
                if (!subject.HasApartment) subject.BankDeposit.IncreaseBalance(_freeMoney - _rentAmount);
                else subject.BankDeposit.IncreaseBalance(_freeMoney);
                subject.BankDeposit.AddMonthlyInterest();
                resultingData[i].DebetAccountBalance = subject.BankDeposit.Balance;
                resultingData[i].MonthNumber = i + 1;
                resultingData[i].HasApartment = subject.HasApartment;
            }

            return resultingData;
        }

        private double DepositAmount(int stepOfDelay) => _apartmentCost * stepOfDelay * Partition;

        private List<Loaner> InitializeTestSubjectsGroup(double mortgagePercentage, double debetPercentage)
        {
            var testSubjectsGroup = new List<Loaner>();
            for (var i = 0; i < 11; i++) testSubjectsGroup.Add(new Loaner(new Mortgage(0, mortgagePercentage), new BankDeposit(0, debetPercentage)));
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
    internal delegate int Name();
}
