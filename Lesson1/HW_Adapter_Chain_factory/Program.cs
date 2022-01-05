using System;
using System.Threading;

namespace HW_Adapter_Chain_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Watch.CreateWatch();
            watch.PrintTime();

            Thread.Sleep(2000);

            var watch1 = Watch.CreateWatch();
            watch1.PrintTime();

            var watch2 = Watch.CreateWatch();
            watch2.PrintTime();

            var watch3 = Watch.CreateWatch();
        }
    }
}
