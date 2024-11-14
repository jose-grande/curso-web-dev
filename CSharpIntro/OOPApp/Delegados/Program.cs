using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FiguraGeometrica cuadrado = new FiguraGeometrica();
            cuadrado.Alto = 200;
            cuadrado.Ancho = 200;
            cuadrado.Imprimir(FormatearDatosCuadrado, DateTime.Now);
            //cuadrado.CalcularArea = CalcularAreaCuadrado;
            // lambda expression
            CalcularArea calcArea= (h, w) => h* w;
            CalcularArea calArea2 = (double h, double w) =>
            {
                var area = h * w;
                return area;
            };
            cuadrado.CalcularArea=calcArea;
            cuadrado.ImprimirArea();

            FiguraGeometrica triangulo = new FiguraGeometrica() { Alto = 250, Ancho=250 };
            // anonymous methods
            triangulo.CalcularArea = (double h, double w)=> (h* w)/2;
            triangulo.ImprimirArea();

            int[] numeros = new int[] { 12, 54, 97, 65, 20 };
            var numerosMenoresQue50 = numeros.Where((int c) => c < 50);
            PruebaFiguras();
        }
        //method signature
        static void Ejemplo(string param1, int param2)
        {

        }
        static string FormatearDatosCuadrado(double h, double w)
        {
            return $"Alto: {h}; Ancho:{w}";
        }
        static double CalcularAreaCuadrado(double h, double w)
        {
            return h * w ;
        }

        static void PruebaFiguras()
        {
            FigurasGeometricas figuras = new FigurasGeometricas();
            
            FiguraGeometrica cuadrado = new FiguraGeometrica();
            cuadrado.Ancho = 250;
            cuadrado.Alto = 250;
            figuras.Agregar(cuadrado);

            FiguraGeometrica circulo = new FiguraGeometrica() { Alto = 30, Ancho=50 };
            figuras.Agregar(circulo);

            figuras.Agregar(new FiguraGeometrica { Alto = 200, Ancho = 200 });
            figuras.Filtrar((FiguraGeometrica f) => f.Alto < 200);
            
            figuras.Filtrar((f) => f.Ancho > 200);
        }
    }
}
