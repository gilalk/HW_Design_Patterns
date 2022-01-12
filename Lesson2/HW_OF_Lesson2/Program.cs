using HW_Proxy;
using System;

namespace HW_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            InteriorOffice interiorOffice = new InteriorOffice();
            ServiceMachineProxy serviceMachine = new ServiceMachineProxy(interiorOffice);

            serviceMachine.ChangeAdress();
            serviceMachine.RenewPassport();
            serviceMachine.ShowMyInfo();
            
        }
    }
}
