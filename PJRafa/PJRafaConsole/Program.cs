//using PJRafaWCF;
using PJRafa_Domain.Entidades;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace PJRafaConsole
{
    class Program
    {
        static void Main()
        {
            teste("03064000");

                using (ServiceHost servHost = 
              new ServiceHost(
                typeof(PJRafa_WCF.ServiceCliente), 
                new Uri[] { new Uri("http://localhost:44129") }))
            {
              try
              {
                servHost.Description.Behaviors.Add(
                  new ServiceMetadataBehavior() { HttpGetEnabled = true });
                servHost.AddServiceEndpoint(
                  typeof(PJRafa_WCF.IServiceCliente), 
                  new BasicHttpBinding(),             
                  "ServiceCliente");
                servHost.Open();
                Console.WriteLine("O serviço está rodando. Pressione ENTER para interromper.");
                Console.ReadLine();
                servHost.Close();
              }
              catch (Exception ex)
              {
                Console.WriteLine("Houve um erro de comunicação. {0}", ex.Message);
                Console.ReadLine();
                servHost.Abort();
              }
            }
        }

        private static void teste(string v)
        {
            Endereco end = new Endereco(v);
        }



        /* #region delete logico
         private static void ExclusãoLogicaCliente()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();
             obj.ExclusãoLogicaCliente(1);
         }

         private static void ExclusãoLogicaEndereco()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();
             obj.ExclusãoLogicaEndereco(3);
         }

         #endregion

         #region inserts
         private static void InserirCliente()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();
             //obj.InserirCliente("Jefferson Victor Da Silva", "547909871", "49745524816", "984544703");
             Main();
         }

         private static void InserirEndereco()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();
             obj.InserirEndereco("0364000", "AV Celso Garcia", "São Paulo", "SP", "4496", 11);
             Main();
         }
         #endregion

         #region updates
         private static void AtualizarCliente()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();
             obj.AtualizarCliente(11,"Jefferson Victor Da Silva", "547909871", "49745524816", "958758960");
             Main();
         }

         private static void AtualizarEndereco()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();
             obj.AtualizarEndereco(4,"0364000", "AV Celso Garcia", "São Paulo", "SP", "4364", 11);
             Main();
         }
         #endregion

         #region selects
         private static void SelecionarClientesDetalhesp()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();
             Cliente cli = obj.SelecionarClientesDetalhes(11);

         }

         private static void SelecionarClientesp()
         {
             PJRafa_Infra.Data.ClienteRepository obj = new PJRafa_Infra.Data.ClienteRepository();

             string a;
             string b;
             string c;

             Console.WriteLine("Digite um nome ou parte dele: \n");
             a = Console.ReadLine();
             Console.WriteLine("Digite um rg ou parte dele: \n");
             b = Console.ReadLine();
             Console.WriteLine("Digite um cpf ou parte dele: \n");
             c = Console.ReadLine();

             List<Cliente> cli = new List<Cliente>();
             cli = obj.SelecionarClientes(a, b, c);

             foreach (var item in cli)
             {

                 Console.WriteLine("ID " + item.Id_Cliente);
                 Console.WriteLine("Nome: " + item.Nome);
                 Console.WriteLine("RG: " + item.RG);
                 Console.WriteLine("CPF: " + item.CPF);
                 Console.WriteLine("Telefone: " + item.Telefone);
                 Console.WriteLine("\n\n");
             }

             Main();
         }
         #endregion

         #region testes
         private static void TesteDictionary()
         {
             var pessoas = new Dictionary<int, aluno>();

             var a1 = new aluno() { Matricula = 123, nome = "bla" };
             var a2 = new aluno() { Matricula = 125, nome = "blabla" };

             pessoas.Add(1, a1);
             pessoas.Add(2, a2);

             foreach (var item in pessoas.Values)
             {
                 Console.WriteLine(item);
             }

             Console.ReadKey();
         }

         private static void Teste124()
         {
             var pessoas = new Hashtable();
             var a1 = new aluno() { Matricula = 123, nome = "bla" };
             var a2 = new aluno() { Matricula = 125, nome = "blabla" };
             var p1 = new professor() { registro = 564, nome = "lololo" };
             pessoas.Add("999", a1);
             pessoas.Add("699", a2);
             pessoas.Add("969", p1);

             foreach (var item in pessoas.Values)
             {
                 Console.WriteLine(item);
             }

             Console.ReadKey();


         }


         private static void Teste123()
         {

             Hashtable turma = new Hashtable();
             turma.Add(488, "xpto");
             turma.Add(689, "fulano");
             turma.Add(569, "siclano");
             turma.Add(685, "belrano");
             turma.Add(356, "chamander");

             Console.WriteLine(turma[569]);
             Console.WriteLine(turma[356]);

             foreach (var item in turma.Keys)
             {
                 Console.WriteLine(item);
             }

             Console.ReadKey();
         }


         static void consoleteste()
         {
             int i = 0;
             Console.WriteLine("escolha um");
             Console.WriteLine("SelecionarClientesDetalhesp[1]\nSelecionarClientesp[2]");
             i = Convert.ToInt16(Console.ReadLine());

             switch (i)
             {
                 case 1:
                     Console.Clear();
                     SelecionarClientesDetalhesp();
                     break;
                 case 2:
                     Console.Clear();
                     SelecionarClientesp();
                     break;
                 case 3:
                     InserirCliente();
                     break;
                 case 4:
                     InserirEndereco();
                     break;
                 case 5:
                     AtualizarCliente();
                     break;
                 case 6:
                     AtualizarEndereco();
                     break;
                 case 7:
                     ExclusãoLogicaCliente();
                     break;
                 case 8:
                     ExclusãoLogicaEndereco();
                     break;
                 default:
                     Console.Clear();
                     Console.ReadKey();
                     break;
             }

             Console.ReadKey();
         }
         #endregion*/
    }
/*#region class teste
    public class aluno
    {
        public int Matricula { get; set; }
        public string nome { get; set; }
        public override string ToString()
        {
            return "Matricula - Nome: \n" + Matricula.ToString() + " - " + nome;
        }
    }
    public class professor
    {
        public int registro { get; set; }
        public string nome { get; set; }
        public override string ToString()
        {
            return "Registro - Nome: \n" + registro.ToString() + " - " + nome;
        }

    }
#endregion*/
}
