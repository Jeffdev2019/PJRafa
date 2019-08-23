using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PJRafa_Domain.Argumentos
{
    [DataContract]
    public class Dto_ClienteFiltroResponse
    {
        public Dto_ClienteFiltroResponse()
        {
                
        }
        public int Id_Cliente { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

    }
}
