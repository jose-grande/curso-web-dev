using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //Object
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal SalarioBase { get; set; }

        public abstract decimal CalcularSalarioNeto();
        public virtual string ToCSV()
        {
            return string.Join(",", Nombre, Apellido);
        }
        
    }
}
