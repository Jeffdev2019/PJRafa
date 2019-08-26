using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaCEP;

namespace PJRafa_Domain.Entidades
{
    public class Endereco
    {
        public Endereco()
        {

        }
        //contrutor deve ser implementado na camada de UI
        public Endereco(string cep)
        {
            var End = ViaCEPClient.Search(cep);
            this.Logradouro = End.Street;

            this.Cidade = End.City;
            this.UF = End.StateInitials;
            int i = 0;
        }
        

        public int Id_Endereco { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }
        
        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Numero { get; set; }

        public int FK_Cliente { get; set; }

    }
}
