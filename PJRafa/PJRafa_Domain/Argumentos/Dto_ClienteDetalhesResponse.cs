using PJRafa_Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PJRafa_Domain.Argumentos
{
    [DataContract]
    public class Dto_ClienteDetalhesResponse
    {

        public Dto_ClienteDetalhesResponse()
        {

        }
        public Dto_ClienteDetalhesResponse(Cliente cli, Endereco end)
        {
            Nome = cli.Nome;
            RG = cli.RG;
            CPF = cli.CPF;
            Telefone = cli.Telefone;
            CEP = end.CEP;
            Logradouro = end.Logradouro;
            Cidade = end.Cidade;
            UF = end.UF;
            Numero = end.Numero;
        }

       
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string RG { get; set; }
        [DataMember]
        public string CPF { get; set; }
        [DataMember]
        public string Telefone { get; set; }
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
    }
}
