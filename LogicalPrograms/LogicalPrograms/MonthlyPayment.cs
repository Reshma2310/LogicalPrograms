using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class MonthlyPayment
    {
        public void Payment()
        {
            double pay;
            double n,r;
            Console.WriteLine("Enter a value for Principle loan amount");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for Years to pay off");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for Percent Interest Compound");
            double R = Convert.ToInt32(Console.ReadLine());
            n = 12 * Y;
            r = R / (12 * 100);
            pay = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly Payment is " + pay);
        }
    }
}
