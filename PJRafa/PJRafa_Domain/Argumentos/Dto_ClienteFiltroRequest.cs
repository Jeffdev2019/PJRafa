using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PJRafa_Domain.Argumentos
{
   
    public class Dto_ClienteFiltroRequest
    {
        public Dto_ClienteFiltroRequest()
        {
            
        }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string RG { get; set; }
        [DataMember]
        public string CPF { get; set; }
    }
}
