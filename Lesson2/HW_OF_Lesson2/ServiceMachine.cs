using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Proxy
{
    public class ServiceMachineProxy : IServiceMachine
    {
        private InteriorOffice interiorOffice;

        public ServiceMachineProxy(InteriorOffice interiorOffice)
        {
            this.interiorOffice = interiorOffice;
        }

        public void ChangeAdress()
        {
            interiorOffice.ChangeAdress();
        }

        public void RenewPassport()
        {
            interiorOffice.RenewPassport();
        }

        public void ShowMyInfo()
        {
            interiorOffice.ShowMyInfo();
        }
    }
}
