using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PJRafa_Domain.Argumentos
{
    public class Dto_AtualizarClienteRequest
    {
        [DataMember]
        public int Id_cliente { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string RG { get; set; }
        [DataMember]
        public string CPF { get; set; }
        [DataMember]
        public string Telefone { get; set; }

    }
}
