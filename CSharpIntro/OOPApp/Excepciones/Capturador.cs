using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Capturador
    {
        public static int LeerEntero()
        {
            var valor=Console.ReadLine();
            int resultado;
            var esNumero = int.TryParse(valor, out resultado);
            if(esNumero)return resultado;
            throw new CustomException();
        }
    }
}
