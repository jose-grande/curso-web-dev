using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class PlanillaService: IPlanillaService
    {
        public int Mes { get; set; }
        public int Año { get; set; }
        public decimal CalcularTotalPagar(int EmpleadoId)
        {
            return 0;
        }
        public decimal CalcularDeducciones(int EmpleadoId)
        {
            return 0;
        }
    }
}
