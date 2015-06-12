using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraspagAPI.Objects
{
    public class Link
    {

        /// <summary>
        /// Metodo(GET, PUT, POST)
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// Nome da Relacao
        /// </summary>
        public string Rel { get; set; }
        /// <summary>
        /// Url
        /// </summary>
        public string Href { get; set; }
    }
}
