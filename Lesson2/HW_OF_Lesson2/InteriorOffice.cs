using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Proxy
{
    public class InteriorOffice : IInteriorOffice, IServiceMachine
    {
        public void AddNewBorn()
        {
            Console.WriteLine("Baby has added, Congratulations!");
        }

        public void ChangeAdress()
        {
            Console.WriteLine("Adress has changed");
        }

        public void RemoveCitizen()
        {
            Console.WriteLine("Citizen has removed, Sorry for your lost!");
        }

        public void RenewPassport()
        {
            Console.WriteLine("USA here I come!");
        }

        public void ShowAllCitizens()
        {
            Console.WriteLine("Citizens Citizens Citizens Citizens Citizens");
        }

        public void ShowMyInfo()
        {
            Console.WriteLine("Info Info Info Info Info");
        }
    }
}
