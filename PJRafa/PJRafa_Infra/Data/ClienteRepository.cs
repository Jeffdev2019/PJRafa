using PJRafa_Domain.Argumentos;
using PJRafa_Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace PJRafa_Infra.Data
{
    public class ClienteRepository
    {
        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSQL"].ToString());

        private System.Data.SqlClient.SqlCommand cmd = new SqlCommand();

        #region selects

        public List<Cliente> selecionartudo()
        {
            cmd = new SqlCommand("selecionartudo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Cliente> Clientes = new List<Cliente>();
                //Endereco end = new Endereco();

                while (dr.Read())
                {
                    Cliente cli = new Cliente();
                    cli.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    cli.Nome = Convert.ToString(dr["Nome"]);
                    cli.RG = Convert.ToString(dr["RG"]);
                    cli.CPF = Convert.ToString(dr["CPF"]);
                    cli.Telefone = Convert.ToString(dr["Telefone"]);
                    Clientes.Add(cli);

                }
                cmd.Connection.Close();
                return Clientes;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Dto_ClienteDetalhesResponse SelecionarClientesDetalhes(int ID) 
        {
            cmd = new SqlCommand("SelecionarClientesDetalhes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));

            

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                //List<Cliente> Clientes = new List<Cliente>();
                Cliente cli = new Cliente();
                Endereco end = new Endereco();

                if(dr.Read())
                {
                    cli.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    cli.Nome = Convert.ToString(dr["Nome"]);
                    cli.RG = Convert.ToString(dr["RG"]);
                    cli.CPF = Convert.ToString(dr["CPF"]);
                    cli.Telefone = Convert.ToString(dr["Telefone"]);                   
                    end.Id_Endereco = Convert.ToInt32(dr["Id_Endereco"]);
                    end.CEP = Convert.ToString(dr["CEP"]);
                    end.Logradouro = Convert.ToString(dr["Logradouro"]);
                    end.Cidade = Convert.ToString(dr["Cidade"]);
                    end.UF = Convert.ToString(dr["UF"]);
                    end.Numero = Convert.ToString(dr["Numero"]);
                }
                cmd.Connection.Close();
                Dto_ClienteDetalhesResponse clie = new Dto_ClienteDetalhesResponse(cli, end); 
                
                return clie;

            }
            catch (Exception ex)
            {
                
                 if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    string x = ex.StackTrace.ToString();
                    cmd.Connection.Close();
                }
                 return null;
            }
 
        }
        public List<Cliente> SelecionarClientes(Dto_ClienteFiltroRequest Request) 
        {

            cmd = new SqlCommand("SelecionarClientes", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (string.IsNullOrEmpty(Request.Nome))
            {
                Request.Nome = Convert.ToString(DBNull.Value);
            }
            if (string.IsNullOrEmpty(Request.RG))
            {
                Request.RG = Convert.ToString(DBNull.Value);
            }
            if (string.IsNullOrEmpty(Request.CPF))
            {
                Request.CPF = Convert.ToString(DBNull.Value);
            }


            cmd.Parameters.Add(new SqlParameter("@nome", Request.Nome));
            cmd.Parameters.Add(new SqlParameter("@rg", Request.RG));
            cmd.Parameters.Add(new SqlParameter("@cpf", Request.CPF));


            try
            {
                cmd.Connection.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Cliente> Clientes = new List<Cliente>();
               
                Endereco end = new Endereco();

                while (dr.Read())
                {
                    Cliente cli = new Cliente();
                    cli.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    cli.Nome = Convert.ToString(dr["Nome"]);
                    cli.RG = Convert.ToString(dr["RG"]);
                    cli.CPF = Convert.ToString(dr["CPF"]);
                    cli.Telefone = Convert.ToString(dr["Telefone"]);
                    Clientes.Add(cli);
                    

                }
                cmd.Connection.Close();
                return Clientes;

            }
            catch (Exception ex)
            {

                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    string x = ex.StackTrace.ToString();
                    cmd.Connection.Close();
                }
                return null;
            }
 
        }
        #endregion

        #region inserts
        public int InserirCliente(Dto_InserirClienteRequest Request) 
        {
            cmd = new SqlCommand("InserirCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nome", Request.Nome));
            cmd.Parameters.Add(new SqlParameter("@rg", Request.RG));
            cmd.Parameters.Add(new SqlParameter("@cpf", Request.CPF));
            cmd.Parameters.Add(new SqlParameter("@Telefone", Request.Telefone));
            int Id_Cliente = 0;

            try
            {
                cmd.Connection.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                }

                cmd.Connection.Close();
                return Id_Cliente;
            }
            catch (Exception)
            {

                return 0;
            }
 
        
        }

        public bool InserirEndereco(Dto_InserirEnderecoRequest Request)
        {
            cmd = new SqlCommand("InserirEndereco", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@cep", Request.CEP));
            cmd.Parameters.Add(new SqlParameter("@logradouro", Request.Logradouro));
            cmd.Parameters.Add(new SqlParameter("@cidade", Request.Cidade));
            cmd.Parameters.Add(new SqlParameter("@uf", Request.UF));
            cmd.Parameters.Add(new SqlParameter("@numero", Request.Numero));
            cmd.Parameters.Add(new SqlParameter("@FK_Cliente", Request.FK_Cliente));

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
        #endregion

        #region update

        public void AtualizarCliente(int id, string Nome, string RG, string CPF, string Telefone)
        {
            cmd = new SqlCommand("AtualizarCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@nome", Nome));
            cmd.Parameters.Add(new SqlParameter("@rg", RG));
            cmd.Parameters.Add(new SqlParameter("@cpf", CPF));
            cmd.Parameters.Add(new SqlParameter("@Telefone", Telefone));

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void AtualizarEndereco(int id, string cep, string log, string city, string uf, string num, int fk_cli)
        {
            cmd = new SqlCommand("AtualizarEndereco", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@cep", cep));
            cmd.Parameters.Add(new SqlParameter("@logradouro", log));
            cmd.Parameters.Add(new SqlParameter("@cidade", city));
            cmd.Parameters.Add(new SqlParameter("@uf", uf));
            cmd.Parameters.Add(new SqlParameter("@numero", num));
            cmd.Parameters.Add(new SqlParameter("@FK_Cliente", fk_cli));

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        #endregion

        #region delete logico
        public void ExclusãoLogicaCliente(int ID)
        {
            cmd = new SqlCommand("ExclusãoLogicaCliente", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ExclusãoLogicaEndereco(int ID)
        {
            cmd = new SqlCommand("ExclusãoLogicaEndereco", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
