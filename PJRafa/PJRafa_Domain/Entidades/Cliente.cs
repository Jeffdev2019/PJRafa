using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJRafa_Domain.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            

        }

        public int Id_Cliente { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public int FK_Endereco { get; set; }
        public Endereco Endereco { get; set; }

       

    }
}
