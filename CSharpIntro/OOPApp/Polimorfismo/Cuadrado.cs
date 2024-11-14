using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cuadrado: FiguraGeometrica
    {
        public string UnidadMedida { get; set; }
        public Cuadrado(double alto, double ancho, string unidadMedida):base(alto, ancho)
        {
            UnidadMedida = unidadMedida;
        }
        public void ImprimirArea()
        {
            double area = CalcularArea();
            Console.WriteLine($"Area = {area}");
        }
        //method override
        public override double CalcularArea()
        {
            return this.Alto * Ancho;
        }
        public void Imprimir(bool imprimirArea)
        {
            if (imprimirArea) {
                Console.WriteLine($"Alto: {Alto}; Ancho: {Ancho}; Area {CalcularArea()}");
            }
            else
            {
                base.Imprimir();
            }
        }
    }
}
