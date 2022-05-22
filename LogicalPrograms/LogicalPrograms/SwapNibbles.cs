using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SwapNibbles
    {
        public void Swapping()
        {
            Console.WriteLine("Enter a number greater than 100 to convert it to Binary");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(binary);
            if (binary.Length % 2 != 0)
            {
                binary = "0" + binary;
            }
            string nibble1 = binary.Substring(0, 4);
            string nibble2 = binary.Substring(4, 4);
            Console.WriteLine("Values are {0} & {1}",nibble1,nibble2);
            string output = nibble2 + nibble1;
            Console.WriteLine("Output after swapping the nibbles " + output);
        }
    }
}
