using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp
{
    public class Estadisticas
    {
        public static double Sumar(double x, double y)
        {
            double sum = x+y;
            UltimoResultado = sum;
            return sum;
        }
        //method overload
        public static double Sumar(double[] numeros)
        {
            double sum = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            UltimoResultado = sum;
            return sum;
        }
        public static double PI
        {
            get
            {
                return 3.14159;
            }
        }
        public const double e = 2.71828;
        public static double UltimoResultado = 0;
        public static double Promedio(params double[] numeros)
        {
            var promedio = 0.0;
            for (int i = 0; i < numeros.Length; i++)
            {
                promedio += numeros[i];
            }
            promedio=promedio/numeros.Length;
            return promedio;
        }
    }
}
