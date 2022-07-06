using System;
using System.Windows.Forms;

namespace MortgagePredictor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*            var s = new Simulation(2000000, 15000, 40000, .2, .2);
                        var a = s.ProcessSimulation(360);
                        for (int i = 0; i < a[5].Count; i++)
                        {
                            Console.Write(a[5][i].DebetAcountBalance + " " + a[5][i].MonthNumber + "\n");
                        }
                        *//*            for (int j = 0; j < a.Count; j++)
                                    {
                                        for (int i = 0; i < a[j].Count; i++) 
                                        {
                                            Console.Write(a[j][i].DebetAcountBalance + " " + a[j][i].MonthNumber + "|");
                                        }
                                        Console.Write("\n");
                                    }
                        *//*
                        while (true) { }
            */
        }
    }
}
