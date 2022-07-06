using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var apartmentPrice = Convert.ToDouble(ApartmentPrice.Value);
            var rentAmount = Convert.ToDouble(RentAmount.Value);
            var freeMoney = Convert.ToDouble(FreeMoney.Value);
            var mortgagePercentage = Convert.ToDouble(MortgagePercentage.Value);
            var debetPercentage = Convert.ToDouble(DebetPercentage.Value);
            _simulation = new Simulation(apartmentPrice, rentAmount, freeMoney, mortgagePercentage, debetPercentage);
        }

        private void Run_Click(object sender, EventArgs e)
        {
            

            var numberOfMonths = Convert.ToInt32(NumberOfMonth.Value);
            var resultsOfSimulation = _simulation.ProcessSimulation(numberOfMonths);
            var message = "";

            for (var i = 0; i < resultsOfSimulation.Count; i++)
            {
                for (var j = 0; j < resultsOfSimulation[i].Count; j++)
                {
                    ResultsChart.Series[i].ChartType = SeriesChartType.Line;
                    ResultsChart.Series[i].Points.AddY(resultsOfSimulation[i][j].DebetAcountBalance);
                    ResultsChart.Series[i].Name = Convert.ToString(i * 10) + "% \nпервоначального взноса";
                }
                message += Convert.ToString(i * 10) + "% \nпервоначального взноса: " + Convert.ToString(resultsOfSimulation[i][resultsOfSimulation[i].Count - 1].DebetAcountBalance) + "\n";
                if (i < resultsOfSimulation.Count - 1) ResultsChart.Series.Add(new Series());
            }
            MessageBox.Show(message);
        }
    }
}
