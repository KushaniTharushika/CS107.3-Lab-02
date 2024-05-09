using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_3
{
    internal class Temperture
    {
            private double[] tempertures; 

            public Temperture()
            {
                tempertures = new double[7];
            }

            public void InputTempertures()
            {
                for (int i = 0; i < tempertures.Length; i++)
                {
                    Console.Write($"Enter temperature for day {i + 1}: ");
                    tempertures[i] = double.Parse(Console.ReadLine());
                }
            }

            public void DisplayWeeklyReport()
            {
                Console.WriteLine("\nWeekly Temperature Report:");
                for (int i = 0; i < tempertures.Length; i++)
                {
                    Console.WriteLine($"Day {i + 1}: {tempertures[i]} °C");
                }
            }
    }
}
