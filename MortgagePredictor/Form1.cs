using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MortgagePredictor
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Simulation _simulation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            ResultsChart.Series.Clear();
            ResultTextBox.Text = "";

            var apartmentPrice = Convert.ToDouble(ApartmentPrice.Value);
            var rentAmount = Convert.ToDouble(RentAmount.Value);
            var freeMoney = Convert.ToDouble(FreeMoney.Value);
            var mortgagePercentage = Convert.ToDouble(MortgagePercentage.Value);
            var debetPercentage = Convert.ToDouble(DebetPercentage.Value);
            _simulation = new Simulation(apartmentPrice, rentAmount, freeMoney, mortgagePercentage, debetPercentage);

            var numberOfMonths = Convert.ToInt32(NumberOfMonth.Value);
            var resultsOfSimulation = _simulation.ProcessSimulation(numberOfMonths);
            var message = "";

            for (var i = 0; i < resultsOfSimulation.Count; i++)
            {
                ResultsChart.Series.Add(new Series());
                for (var j = 0; j < resultsOfSimulation[i].Count; j++)
                {
                    ResultsChart.Series[i].ChartType = SeriesChartType.Line;
                    ResultsChart.Series[i].Points.AddY(resultsOfSimulation[i][j].DebetAcountBalance);
                    ResultsChart.Series[i].Name = Convert.ToString(i * 10) + "% первоначального взноса";
                }
                var finalDebetBalance = Math.Round(resultsOfSimulation[i][resultsOfSimulation[i].Count - 1].DebetAcountBalance, 2);
                if (i == 0) message += Convert.ToString(i * 10) + "%     первоначального взноса: " + Convert.ToString(finalDebetBalance);
                else if (i < 10) message += Convert.ToString(i * 10) + "%   первоначального взноса: " + Convert.ToString(finalDebetBalance);
                else message += Convert.ToString(i * 10) + "% первоначального взноса: " + Convert.ToString(finalDebetBalance);
                message += resultsOfSimulation[i][resultsOfSimulation[i].Count - 1].HasAnApartment ? " Квартира куплена\r\n" : " Квартира не куплена\r\n";
            }
            
            ResultTextBox.Text += message;
        }
    }
}
