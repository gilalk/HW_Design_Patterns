using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Prototype
{
    public class Invoice
    {
        public Client client { get; set; }
        public int PaidBill { get; set; }
        public int VAT = 17;
        public DateTime DealDate { get; set; }

        public Invoice()
        {

        }
        public Invoice(Client client, int bill, DateTime dealDate)
        {
            this.client = client;
            this.DealDate = dealDate;
            this.PaidBill = bill + (bill * (VAT / 100));
        }

        public Invoice Clone()
        {
            Invoice cloneInvoice = new Invoice(this.client/*.Clone()*/, this.PaidBill, this.DealDate);
            return cloneInvoice;
        }

        public override string ToString()
        {
            return $"Client: {client.FullName}, {client.Id}, {client.CreditInfo} \nDeal Date: {DealDate}";
        }
    }
}
