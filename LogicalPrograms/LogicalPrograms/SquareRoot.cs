using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SquareRoot
    {
        public void Square()
        {
            Console.WriteLine("Enter a number to find its Squareroot");
            double num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Squareroot of {0} is {1}", num, Math.Sqrt(num));
        }
    }
}
