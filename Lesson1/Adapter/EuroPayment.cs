using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class EuroPayment : IEuroPayment
    {
        public double EuroPay(int dollarPayment)
        {
            double paymaentInEuro = dollarPayment * 0.88;
            return paymaentInEuro;
        }
    }
}
