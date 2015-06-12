using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraspagAPI.Objects
{
    public class CreditCard
    {

        /// <summary>
        /// Número do Cartão do Comprador
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// Nome do Comprador impresso no cartão
        /// </summary>
        public string Holder { get; set; }
        /// <summary>
        /// Data de validade impresso no cartão
        /// </summary>
        public string ExpirationDate { get; set; }
        /// <summary>
        /// Código de segurança impresso no verso do cartão
        /// </summary>
        public string SecurityCode { get; set; }
        /// <summary>
        /// Booleano que identifica se o cartão será salvo para gerar o CardToke
        /// </summary>
        public bool SaveCard { get; set; }
        /// <summary>
        /// Bandeira do cartão
        /// </summary>
        public string Brand { get; set; }
    }
}
