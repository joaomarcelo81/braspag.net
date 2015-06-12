using BraspagMedigitalAPI;
using BraspagMedigitalAPI.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           /* PaymentApi RequestPayment = new PaymentApi("", "");
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

            var saida = RequestPayment.CreateSale(sale);*/
            return View();
        }


        [HttpPost]
        public ActionResult Pagamento(string CardNumber, string Holder, string ExpirationDate, string SecurityCode, string Brand, decimal valor)
        {
            var CreditCard = new CreditCard()
                {
                    CardNumber = CardNumber,
                    Holder = Holder,
                    ExpirationDate = ExpirationDate,
                    SecurityCode = SecurityCode,
                    SaveCard =false,
                    Brand = Brand
                };
            PaymentApi RequestPayment = new PaymentApi("", "");
            Sale sale = new Sale();
            sale.MerchantOrderId = "20014259865";
            sale.Customer = new Customer()
            {
                Name = "Comprador Teste"
            };

            sale.Payment = new Payment()
            {
                Type = "CreditCard",
                Amount = valor,
                Provider = "Simulado",//
                Installments = "1",
                CreditCard = CreditCard
            };

            var saida = RequestPayment.CreateSale(sale);

            return View(saida);


        }



        [HttpPost]
        public ActionResult Boleto()
        {
            PaymentApi RequestPayment = new PaymentApi("", "");
            Sale sale = new Sale();
            sale.MerchantOrderId = "20014259865";
            sale.Customer = new Customer()
            {
                Name = "João Marcelo de Mello Vasconcellos"
            };
            sale.Payment = new Payment()
            {
                Type = "Boleto",
                Amount = 120,
                Provider = "Simulado",
                Address = "Rua Teste",
                BoletoNumber = "123",
                Assignor = "DARWIN Teste",
                Demonstrative = "Desmonstrative Teste",
                ExpirationDate = "2015-01-05",
                Identification = "11884926754",
                Instructions = "TESTE DE BOLETO LIGAÇÂO COM DARWIN"
               // Instructions = "Aceitar somente até a data de vencimento, após essa data juros de 1% dia."
            };
            var saida = RequestPayment.CreateSale(sale);
            return View(saida);

        }


        public ActionResult RetornoCompra()
        {
            return View();
        }
    }
}