using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci
    {
        public void FibonacciSeries()
        {
            int num1=0,num2=1, num3, value;
            Console.WriteLine("Enter a number");
            value=int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2 + " ");
            for (int i = 2; i < value; ++i)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
