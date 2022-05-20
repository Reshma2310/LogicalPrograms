using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics; // to use Stopwatch feature
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public void StopwatchOutput()
        {
            Console.WriteLine("Enter a time span in Seconds to pause the program");
            int value = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopw=new Stopwatch();
            stopw.Start();
            for (int i = 0; i < value; i++)
            {
                Thread.Sleep(1000);
            }
            stopw.Stop();
            Console.WriteLine("Time paused is {0} ", stopw.Elapsed);
        }
    }
}
