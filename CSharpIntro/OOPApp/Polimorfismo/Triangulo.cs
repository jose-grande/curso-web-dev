using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangulo: FiguraGeometrica
    {
        public void ImprimirArea()
        {
            double area = CalcularArea();
            Console.WriteLine($"Area = {area}");
        }
        public override double CalcularArea()
        {
            return (this.Alto * this.Ancho) / 2;
        }
    }
}
