using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class BDPlanillaService : IPlanillaService
    {
        public int Mes { get; set; }
        public int Año { get; set; }

        public decimal CalcularDeducciones(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTotalPagar(int empleadoId)
        {
            throw new NotImplementedException();
        }
    }
}
