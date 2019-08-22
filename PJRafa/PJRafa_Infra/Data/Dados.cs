using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace PJRafa_Infra.Data
{
    public class Dados
    {
       

        public static DataTable RetornarTabela(string Proc,
           Dictionary<string, object> parametros,
           out string mensagem)
         {
           using (SqlDataAdapter daConsulta = new SqlDataAdapter
           {
             SelectCommand = new SqlCommand
             {
               CommandText = Proc,
               CommandType = CommandType.StoredProcedure,
               Connection =  new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSQL"].ToString())
             }
           })
           {
             try
             {
               ConfigurarParametros(daConsulta.SelectCommand, parametros);
     
               using (DataTable dtRet = new DataTable("ClienteDetalhe"))
               {
                 daConsulta.Fill(dtRet);
                 mensagem = string.Empty;
                 return dtRet;
               }
             }
             catch (Exception ex)
             {
               mensagem = string.Format("Não foi possível executar a procedure.\n{0}",
                 ex.Message);
             }
             finally
             {
               if (daConsulta.SelectCommand.Connection.State == 
                 ConnectionState.Open)
                 daConsulta.SelectCommand.Connection.Close();
             }
           }
     
           return new DataTable("default");
         }

        //Executa um comando SQL
        internal static bool ExecutarSQL(string Proc, 
           Dictionary<string, object> parametros, out string mensagem)
         {
           using (SqlCommand SqlCmd = new SqlCommand
           {
             CommandText = Proc,
             CommandType = CommandType.StoredProcedure,
             Connection =  new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSQL"].ToString())
             
           })
           {
             try
             {
               ConfigurarParametros(SqlCmd, parametros);
               SqlCmd.Connection.Open();
               SqlCmd.ExecuteNonQuery();
               mensagem = string.Empty;
             }
             catch (Exception ex)
             {
               mensagem = string.Format("Não foi possível executar o comando SQL.\n{0}",
                 ex.Message);
             }
             finally
             {
               SqlCmd.Connection.Close();
             }
           }
     
           return string.IsNullOrEmpty(mensagem);
         }

        //Configuração dos parâmetros SQL
         private static void ConfigurarParametros(SqlCommand SqlCmd, 
           Dictionary<string, object> parametros)
         {
           foreach (string key in parametros.Keys)
           {
             SqlCmd.Parameters.AddWithValue(key, parametros[key]);
           }
         }


    }
}
