using System.Runtime.Serialization;

namespace PJRafa_Domain.Argumentos
{
    public class Dto_InserirClienteRequest
    {
        public Dto_InserirClienteRequest()
        {

        }

        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string RG  { get; set; }
        [DataMember]
        public string CPF  { get; set; }
        [DataMember]
        public string Telefone { get; set; }
   
        
    }
}
