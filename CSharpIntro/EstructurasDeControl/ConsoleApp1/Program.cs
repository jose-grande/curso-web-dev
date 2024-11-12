using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // base 0
            int[] numeros=new int[5];
            numeros[0] = 25;
            numeros[4] = 50;

            Console.WriteLine($"numeros[4]={numeros[4]}");

            string[] diccionario = new string[10];
            Console.WriteLine("Escriba los 10 elementos del diccionario");
            for(int i = 0; i < diccionario.Length; i++)
            {
                Console.WriteLine("Escriba el termino " + i);
                diccionario[i] = Console.ReadLine();
            }
            Console.WriteLine("Terminos ingresados en el diccionario");
            for (int x = 0; x < diccionario.Length; x++)
            {
                Console.WriteLine(diccionario[x]);
            }
            string[] telefonos;
            int longitud;
            Console.WriteLine("Cuantos numero de telefono desea almacenar");
            longitud = int.Parse(Console.ReadLine());
            telefonos=new string[longitud];

            double[] precios =new double[] { 25.4, 30.2, 65.5 };
            //double[] precios2 = [ 25.4, 30.2, 65.5 ];
        }
    }
}
