using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TemperatureConvertion
    {
        public void TempConvert()
        {
            Console.WriteLine("Choose an option for Temperature Convertion\n1. Convert Celsius to Fahrenheit\n2. Convert Fahrenheit to Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter temperatue in Celsius");
                    float Celsius1 = Convert.ToInt32(Console.ReadLine());
                    float Fahren1 = (Celsius1 * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit is " + Fahren1);
                    break;
                case 2:
                    Console.WriteLine("Enter temperature in Fahrenheit");
                    float Fahren2= Convert.ToInt32(Console.ReadLine());
                    float Celsius2 = (Fahren2 - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius is " + Celsius2);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
