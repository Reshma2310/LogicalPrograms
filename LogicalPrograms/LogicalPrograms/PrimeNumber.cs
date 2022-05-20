using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void Prime()
        { 
        Console.WriteLine("Enter Range to print prime numbers FirstNum and LastNum");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Numbers between {0} and {1}",num1,num2);
            for (int i = num1; i <= num2; i++)
            {
                int res = 0;
                for (int j = 2; j <= i/2; j++)
                {              
                    if(i % j == 0)
                    {
                        res=1;
                        break;
                    }
                }
                if (res == 0 && i != 1)
                {
                    Console.WriteLine("{0}",i);
                }
            }
            Console.ReadKey();
        }
    }
}
