using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Adapter_Chain_factory
{
    public class Watch
    {
        private long MyTime { get; set; }
        private static Watch watch;
        private static object key = new object();

        private Watch()
        {
            MyTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        public static Watch CreateWatch()
        {
            if(watch == null)
            {
                lock (key)
                {
                    watch = new Watch();
                    return watch;
                }
            }
            return watch;
        } 

        public void PrintTime()
        {
            Console.WriteLine($"Creating Time: {MyTime}");
        }
    }
}
