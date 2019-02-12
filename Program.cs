using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Startup
{
    class Program
    {
        static readonly AutoResetEvent signal = new AutoResetEvent(true);
        //static int FIFO = 10;

        static void Main(string[] args)
        {
            TimeTracker tt = new TimeTracker("start");

            Console.WriteLine("Lap 1 started");
            Thread.Sleep(100);
            Console.WriteLine("Lap 1 stopped\n");
            tt.AddLap("Lap1");

            Console.WriteLine("Lap 2 started");
            Thread.Sleep(300);
            Console.WriteLine("Lap 2 stopped\n");
            tt.AddLap("Lap2");

            Console.WriteLine("Lap 3 started");
            Thread.Sleep(400);
            Console.WriteLine("Lap 3 stopped\n");
            tt.AddLap("Lap3");

            Console.WriteLine("Lap 4 started");
            Thread.Sleep(500);
            Console.WriteLine("Lap 4 stopped\n");
            tt.AddLap("Lap4");

            Console.WriteLine("Lap1 completed after " + tt.GetLapTimeDiff("start", "Lap1") + " ms");
            Console.WriteLine("Lap2 completed after " + tt.GetLapTimeDiff("start", "Lap2") + " ms");
            Console.WriteLine("Lap3 completed after " + tt.GetLapTimeDiff("start", "Lap3") + " ms");
            Console.WriteLine("Lap4 completed after " + tt.GetLapTimeDiff("start", "Lap4") + " ms");

        }       
    }

}
