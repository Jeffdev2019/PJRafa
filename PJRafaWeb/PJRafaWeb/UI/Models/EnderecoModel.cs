using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViaCEP;

namespace UI.Models
{
    public class EnderecoModel
    {
        public EnderecoModel()
        {

        }
        //contrutor deve ser implementado na camada de UI
        public EnderecoModel(string cep)
        {
            var End = ViaCEPClient.Search(cep);
            this.Logradouro = End.Street;
            this.Cidade = End.City;
            this.UF = End.StateInitials;
        }
    


        public int Id_Endereco { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Numero { get; set; }

    }
}