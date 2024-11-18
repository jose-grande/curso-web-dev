using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class FiguraGeometrica//: object
    {
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public FiguraGeometrica() { 
        }
        public FiguraGeometrica(double alto, double ancho) 
        { 
            this.Alto = alto;
            this.Ancho = ancho;
        }
        public virtual double CalcularArea()
        {
            return 0;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Alto: {Alto}; Ancho: {Ancho}");
        }
    }
}
