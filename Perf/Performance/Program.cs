using HansPlc;
using System;
using Vortex.Connector;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry.HansPlc.Connector.BuildAndStart().ReadWriteCycleDelay = 1000000000;

            Console.WriteLine("Reading symbols...");
            Entry.HansPlc.prgPerf.Read();

            var sw = new System.Diagnostics.Stopwatch();
            while(true)
            {
                Console.Clear();

                sw.Restart();                
                Entry.HansPlc.prgPerf.hugeArrayOfPrimitive.Read();
                sw.Stop();
                Console.WriteLine($"Read: '{nameof(Entry.HansPlc.prgPerf.hugeArrayOfPrimitive)}'\t\t\t\t{sw.ElapsedMilliseconds}\tms (byte size: 10,24)");
                
                sw.Restart();
                Entry.HansPlc.prgPerf.hugeArrayOfComplex.Read();
                sw.Stop();
                Console.WriteLine($"Read: '{nameof(Entry.HansPlc.prgPerf.hugeArrayOfComplex)}'\t\t\t\t{sw.ElapsedMilliseconds}\tms (byte size: 267,000)");


                sw.Restart();
                Entry.HansPlc.prgPerf.hugeStructureOfPrimitive.Read();
                sw.Stop();
                Console.WriteLine($"Read: '{nameof(Entry.HansPlc.prgPerf.hugeStructureOfPrimitive)}'\t\t\t{sw.ElapsedMilliseconds}\tms (byte size: 1,024)");

                sw.Restart();
                Entry.HansPlc.prgPerf.hugeStructureOfComplex.Read();
                sw.Stop();
                Console.WriteLine($"Read: '{nameof(Entry.HansPlc.prgPerf.hugeStructureOfComplex)}'\t\t\t\t{sw.ElapsedMilliseconds}\tms (byte size: 26,700)");

                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
