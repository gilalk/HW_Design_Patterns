using System;
using System.Text.Json;

namespace HW_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client(3123, "Gil Alkobi", "307768gh");
            Invoice invoice = new Invoice(client, 500, new DateTime(2021, 10, 28));

            //Invoice cloneInvoice = invoice.Clone();
            //Console.WriteLine(cloneInvoice);

            // trying with deepcopy

            Invoice cloneInvoice1 = DeepCopy<Invoice>(invoice);
            Console.WriteLine(cloneInvoice1);
            client.FullName = "Avichi";
            Console.WriteLine(invoice);
        }

        public static T DeepCopy<T>(T info)
        {
            var json = JsonSerializer.Serialize(info);
            T obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        } 

    }
}
