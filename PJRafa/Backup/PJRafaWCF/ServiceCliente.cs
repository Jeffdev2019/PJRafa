using PJRafa_Domain.Entidades;
using PJRafa_Infra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PJRafaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceCliente  : IServiceCliente
    {
        public List<Cliente> selecionartudo()
        {
           ClienteRepository obj = new ClienteRepository();

           return obj.selecionartudo(); 
 
        
        }

        public DataTable Consultar(string usuario, out string mensagem, string Nome = null, string RG = null, string CPF = null)
        {
          /*if (!AutenticarUsuario(usuario, out mensagem))
          {
            return null;
          }*/

          string ComandoSql = "SelecionarClientesDetalhes";
    
          Dictionary<string, object> parametros = new Dictionary<string, object> 
          {
              { "@nome" , string.Format("%{0}%", Nome) },
              { "@rg" , string.Format("%{0}%", RG) },
              { "@cpf" , string.Format("%{0}%", CPF) }
              
          };
    
          return Dados.RetornarTabela(ComandoSql, parametros, out mensagem);
        }

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
