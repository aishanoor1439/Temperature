using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: temperature in Celsius
            Console.WriteLine("Enter the temperature in Celsius: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            // Determine and display the message according to the temperature state
            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("Normal in Temperature");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("It's Hot");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("It's Very Hot");
            }
        }
    }
}
