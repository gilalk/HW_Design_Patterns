using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability
{
    class PrimaryCheck : Car
    {

        public override void HandleRequest()
        {
            int grade = new Random().Next(1, 11);
            if(grade > 6)
            {
                CarIsOK = true;
                Console.WriteLine("Take your car, it is fixed!");
            }
            else
            {
                if(next != null)
                {
                    Console.WriteLine("Primary check failed, moving on!");
                    next.HandleRequest();
                }
            }
        }
    }
}
