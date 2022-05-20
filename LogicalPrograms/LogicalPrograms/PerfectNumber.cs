using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int value=0;
            Console.WriteLine("Enter a Number to check if it is perfect number");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= (num/2); i++)
            {
                if (num % i == 0)
                {
                    value = value + i;
                }
            }
            if (value == num)
            {
                Console.WriteLine("{0} is a perfect number",num);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", num);
            }
        }
    }
}
