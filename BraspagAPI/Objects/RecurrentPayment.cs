using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraspagAPI.Objects
{
    public class RecurrentPayment
    {
        /// <summary>
        /// Booleano para saber se a primeira recorrencia já vai ser Autorizada ou não
        /// </summary>
        public bool AuthorizeNow { get; set; }
        /// <summary>
        /// Data do fim da recorrência. 
        /// </summary>
        public string EndDate { get; set; }
        /// <summary>
        /// Intervalo entre as recorrência
        /// Monthly (Default) 
        /// Bimonthly 
        /// Quarterly 
        /// SemiAnnual 
        /// Annual 
        /// </summary>
        public string Interval { get; set; }
        /// <summary>
        /// Data do inicio da recorrência. 
        /// </summary>
        public string StartDate { get; set; }
        /// <summary>
        /// Campo Identificador da próxima recorrência
        /// </summary>
        public string RecurrentPaymentId { get; set; }
        /// <summary>
        /// Código da razão da Operação
        /// </summary>
        public string ReasonCode { get; set; }
        /// <summary>
        /// Mensagem da razação da Operação
        /// </summary>
        public string ReasonMessage { get; set; }
        /// <summary>
        /// Data da próxima recorrência
        /// </summary>
        public string NextRecurrency { get; set; }
        /// <summary>
        /// Link de chamada da Recorrencia
        /// </summary>
        public Link Link { get; set; }
    }

}
