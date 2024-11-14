using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate string FormatearFigura(double alto, double ancho);
    public delegate double CalcularArea(double alto, double ancho);
    public class FiguraGeometrica
    {
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public CalcularArea CalcularArea { get; set; }
        public void Imprimir(FormatearFigura metodo, DateTime fechaImpresion)
        {
            string valorFormateado = metodo(this.Alto, this.Ancho);
            valorFormateado += " " + fechaImpresion.ToString();
            Console.WriteLine(valorFormateado);
        }
        public void ImprimirArea()
        {
            double area = CalcularArea(this.Alto, this.Ancho);
            Console.WriteLine($"El area de la figura es: {area}");
        }
    }
}
