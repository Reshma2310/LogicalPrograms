using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a number to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while(num > 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number is " + rev);
        }
    }
}
