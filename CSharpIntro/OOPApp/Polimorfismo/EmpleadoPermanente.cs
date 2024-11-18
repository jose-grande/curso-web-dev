using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class EmpleadoPermanente : Empleado
    {
        public override decimal CalcularSalarioNeto()
        {
            var ihss = SalarioBase * 0.035M;
            return SalarioBase- ihss;
        }
        public override string ToCSV()
        {
            return base.ToCSV() +$", {CalcularSalarioNeto()}";
        }
            
    }
}
