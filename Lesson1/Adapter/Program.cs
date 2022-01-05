using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDollarPayment paymentSys = new AdapterChange();
            Payment(paymentSys, 10);

            IDollarPayment paymentSys1 = new DollarPayment();
            Payment(paymentSys1, 10);

        }

        public static void Payment(IDollarPayment payroll , int payment)
        {
            Console.WriteLine($"{payroll.DollarPay(payment)} has paid successfully");
        }
    }
}
