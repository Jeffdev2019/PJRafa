using PJRafa_Domain.Argumentos;
using PJRafa_Domain.Entidades;
using PJRafa_Infra.Data;
using System.Collections.Generic;
using System.Data;

namespace PJRafa_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    
    public class ServiceCliente : IServiceCliente
    {
        public ClienteRepository obj = new ClienteRepository();
        #region Select
        public List<Cliente> selecionartudo()
        {
           

            return obj.selecionartudo();


        }

        public List<Cliente> FiltrarClientes(Dto_ClienteFiltroRequest Clil)
        {
            return obj.SelecionarClientes(Clil);
        }

        public Dto_ClienteDetalhesResponse Consultar(int Id)
        {
             
            return obj.SelecionarClientesDetalhes(Id);
        }
        #endregion


        public int InserirCliente(Dto_InserirClienteRequest Request)
        {
            return obj.InserirCliente(Request);
        }

        public bool InserirEndereco(Dto_InserirEnderecoRequest Request)
        {
            return obj.InserirEndereco(Request);
        }

        /* public List<Cliente> Consultar(Dto_ClienteFiltro Cli)
        {
            /*if (!AutenticarUsuario(usuario, out mensagem))
            {
              return null;
            }*/



        /* Dictionary<string, object> parametros = new Dictionary<string, object>
       {
           { "@nome" , string.Format("%{0}%", cli. Nome) },
           { "@rg" , string.Format("%{0}%", RG) },
           { "@cpf" , string.Format("%{0}%", CPF) }

       };

         return obj.SelecionarClientes(Cli);
     }*/

        /*private bool AutenticarUsuario(string usuario, out string mensagem)
        {
          string ComandoSql = @"
            SELECT Nome FROM Usuario 
            WHERE Email = @Email";
    
          Dictionary<string, object> parametros =
            new Dictionary<string, object> 
            {
                { "@Email", usuario }
            };
    
          if (Dados.RetornarTabela(ComandoSql, parametros, out mensagem).Rows.Count == 0
            && string.IsNullOrEmpty(mensagem))
              mensagem = @"Usuário não encontrado.";
    
          return string.IsNullOrEmpty(mensagem);
        }*/
    }
}
