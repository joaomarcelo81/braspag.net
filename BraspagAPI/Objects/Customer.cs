using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraspagMedigitalAPI.Objects
{
    public class Customer
    {
        /// <summary>
        /// Nome do Comprador
        /// </summary>
        public string Name { get; set; }
        public string Identity { get; set; }
        /// <summary>
        /// Tipo do documento de identificação do Comprador
        /// </summary>
        public string IdentityType { get; set; }
        /// <summary>
        /// Email do Comprador
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Data de nascimento do Comprador
        /// </summary>
        public string Birthdate { get; set; }

    }
}
