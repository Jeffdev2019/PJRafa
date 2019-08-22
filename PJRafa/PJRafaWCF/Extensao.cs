using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJRafaWCF
{
    public static class Extensao
    {
      public static string AjustarString(this string valor, int tamanho)
      {
        return valor.Length <= tamanho ? valor : valor.Substring(0, tamanho - 1);
      }
    }
}
