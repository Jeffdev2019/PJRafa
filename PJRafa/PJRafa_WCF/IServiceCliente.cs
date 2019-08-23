
using PJRafa_Domain.Argumentos;
using PJRafa_Domain.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace PJRafa_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceCliente
    {
        [OperationContract]
        List<Cliente> selecionartudo();

        [OperationContract]
        List<Dto_ClienteFiltroResponse> FiltrarClientes(Dto_ClienteFiltroRequest Request);

        [OperationContract]
        Dto_ClienteDetalhesResponse Consultar(int Id);

        [OperationContract]
        int InserirCliente(Dto_InserirClienteRequest Request);

        [OperationContract]
        bool InserirEndereco(Dto_InserirEnderecoRequest Request);

        [OperationContract]
        bool AtualizarCliente(Dto_AtualizarClienteRequest Request);
        [OperationContract]
        bool AtualizarEndereco(Dto_AtualizarEnderecoRequest request);
        [OperationContract]
        bool ExcluirCliente(int Id);
        [OperationContract]
        bool ExcluirEnderco(int Id);


        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "PJRafaWCF.ContractType".
    
}
