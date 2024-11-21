using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CustomException:Exception
    {
        public CustomException():base("El numero no se encontro en el formato correcto")
        {
            
        }
    }
}
