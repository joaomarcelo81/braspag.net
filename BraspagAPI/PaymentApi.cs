using BraspagAPI.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BraspagAPI
{

    /// <summary>
    /// Object to request Payment
    /// </summary>
    public class PaymentApi
    {

        public static string _merchantId { get; set; }
        public static string _merchantKey { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="MerchantId"></param>
        /// <param name="MerchantKey"></param>
        public PaymentApi(string MerchantId, string MerchantKey)
        {
            _merchantId = MerchantId;
            _merchantKey = MerchantKey;
        }

        /// <summary>
        /// Criando uma venda simplificada
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        public Sale CreateSale(Sale sale)
        {
            var retorno = (HttpPost(sale, ""));
           var vendaresult = JsonConvert.DeserializeObject<Sale>(retorno);
            
           return vendaresult;
        }

        /// <summary>
        /// Criando uma venda completa
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        public string CriarVendaCompleta(Sale sale)
        {
            var retorno = (HttpPost(sale, ""));
            var vendaresult = JsonConvert.DeserializeObject<Sale>(retorno);
            return retorno;
        }


        /// <summary>
        /// Capturar
        /// </summary>
        /// <param name="PaymentId"></param>
        /// <param name="amount"></param>
        /// <param name="serviceTaxAmount"></param>
        /// <returns></returns>
        public Sale CapturandoSale(string PaymentId, string amount, string serviceTaxAmount)
        {
             var retorno = HttpRequest(PaymentId, "capture", amount, serviceTaxAmount, "put", "apisandbox");
             var result = JsonConvert.DeserializeObject<Sale>(retorno);
             return result;
        }


        /// <summary>
        /// Cancelar
        /// </summary>
        /// <param name="PaymentId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public Sale CancelarSale(string PaymentId, string amount)
        {
            var retorno = HttpRequest(PaymentId, "void", amount, null, "put", "apisandbox");
            var result = JsonConvert.DeserializeObject<Sale>(retorno);
            return result;
        }


        public Sale ConsultarSale(string PaymentId)
        {
            var retorno = HttpRequest(PaymentId, string.Empty, string.Empty, null, "get", "apiquerysandbox");
            var result = JsonConvert.DeserializeObject<Sale>(retorno);
            return result;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="PaymentId">The payment Id</param>
        /// <param name="method">Capture or Cancelar</param>
        /// <param name="amount"></param>
        /// <param name="serviceTaxAmount"></param>
        /// <returns></returns>
        private static string HttpRequest(string PaymentId, string Command, string amount, string serviceTaxAmount, string method, string urlconection)
        {
            
            var url = string.Format("https://" + urlconection + ".braspag.com.br/v2/sales/{0}{1}", PaymentId, (string.IsNullOrWhiteSpace(Command) ? string.Empty : "/" + Command));


            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = method;//"PUT";
          //  request.Headers.Add("MerchantId", "db0655e8-c002-4981-9254-2056886139e3");
//            request.Headers.Add("MerchantKey", "QUOKIYZWQXBMGUUTSRXJSSJJKSLJFGJCOXWNNROG");
            request.Headers.Add("MerchantId", _merchantId);
            request.Headers.Add("MerchantKey", _merchantKey);
            request.Headers.Add("RequestId", Guid.NewGuid().ToString());
            request.ContentType = "application/json";


            if (!string.IsNullOrWhiteSpace(amount))
            {
                var postData = "?";
                postData += "amount=" + amount;
                postData += "%serviceTaxAmount=" + serviceTaxAmount;
                var data = Encoding.ASCII.GetBytes(postData);
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }



            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="venda"></param>
        /// <param name="urlCompra">Url de Compra</param>
        /// <returns></returns>
        private static string HttpPost(Sale sale, string urlCompra)
        {

            var request = (HttpWebRequest)WebRequest.Create((string.IsNullOrEmpty(urlCompra) ? "https://apisandbox.braspag.com.br/v2/sales" : urlCompra));

            request.Method = "POST";
            //  request.Headers.Add("MerchantId", "db0655e8-c002-4981-9254-2056886139e3");
            //            request.Headers.Add("MerchantKey", "QUOKIYZWQXBMGUUTSRXJSSJJKSLJFGJCOXWNNROG");
            request.Headers.Add("MerchantId", _merchantId);
            request.Headers.Add("MerchantKey", _merchantKey);
            request.Headers.Add("RequestId", Guid.NewGuid().ToString());
            request.ContentType = "application/json";

            var postData = JsonConvert.SerializeObject(sale, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });

            var data = Encoding.ASCII.GetBytes(postData);

            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;

        }




        
    }
}
