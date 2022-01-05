using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterChange : IDollarPayment
    {
        private IEuroPayment euroPayment = new EuroPayment();

        public double DollarPay(int payment)
        {
            return euroPayment.EuroPay(payment);
        }
    }
}
