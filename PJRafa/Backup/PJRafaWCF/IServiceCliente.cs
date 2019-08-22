using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PJRafa_Domain.Entidades;
using PJRafa_Infra.Data;
using System.Data;

namespace PJRafaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceCliente
    {
        [OperationContract]
        List<Cliente> selecionartudo();
        

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "PJRafaWCF.ContractType".
    [DataContract]
    public class DadosCliente
    {
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
