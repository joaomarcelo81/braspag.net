
using BraspagMedigitalAPI;
using BraspagMedigitalAPI.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            PaymentApi RequestPayment = new PaymentApi(
                "db0655e8-c002-4981-9254-2056886139e3"
                , "QUOKIYZWQXBMGUUTSRXJSSJJKSLJFGJCOXWNNROG");
            Sale sale = new Sale();
            sale.MerchantOrderId = "20014259865";
            sale.Customer = new Customer()
            {
                Name = "Comprador Teste"
            };

            sale.Payment = new Payment()
            {
                Type = "CreditCard",
                Amount = 15700,
                Provider = "Simulado",
                Installments = "1",
                CreditCard = new CreditCard()
                {
                    CardNumber = "1234123412341231",
                    Holder = "Teste Holder",
                    ExpirationDate = "12/2021",
                    SecurityCode = "123",
                    Brand = "Visa"
                }
            };


            var saida = RequestPayment.CreateSale(sale);
            Console.WriteLine(saida);
            Console.Read();

        }
    }
}
