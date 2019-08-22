using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PJRafa_Domain.Argumentos
{
    public class Dto_InserirEnderecoRequest
    {
        public Dto_InserirEnderecoRequest()
        {

        }
        [DataMember]
        public string CEP { get; set; }
        [DataMember]
        public string Logradouro { get; set; }
        [DataMember]
        public string Cidade { get; set; }
        [DataMember]
        public string UF { get; set; }
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public int FK_Cliente { get; set; }
    }
}
