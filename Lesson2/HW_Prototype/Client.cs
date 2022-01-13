using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Prototype
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CreditInfo { get; set; }

        public Client(int id, string fullName, string creditInfo)
        {
            Id = id;
            FullName = fullName;
            CreditInfo = creditInfo;
        }

        public Client Clone()
        {
            Client client1 = new Client(this.Id, this.FullName, this.CreditInfo);
            return client1;
        }
    }
}
