using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class DayOfWeek
    {
        public void DayOutput()
        {            
            string[] Days = {"Sunday","Monday","Tuesday","Wednesday","Thusday","Friday","Saturday"};
            Console.WriteLine("Printing the day as output by receiving date as input");
            Console.WriteLine("Enter date between 1 to 31");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month between 1 to 12");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an year with 4 digit number or greater");
            int y= Convert.ToInt32(Console.ReadLine());
            if (1 <= d && d <= 31 && 1 <= m && m <= 12 && 1000 <= y && y <= 10000)
            {
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + (31 * m0) / 12) % 7;
                Console.WriteLine("The day of the Input date is " + Days[d0]);
            }
            else
                Console.WriteLine("Invalid input, Select another date");
        }
    }
}
