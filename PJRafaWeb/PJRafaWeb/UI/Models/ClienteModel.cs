using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models
{
    public class ClienteModel
    {
        public ClienteModel()
        {

        }

        public int Id_Cliente { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }



    }
}