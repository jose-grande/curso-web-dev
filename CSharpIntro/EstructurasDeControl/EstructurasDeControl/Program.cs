using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
    internal class Program
    {
        /*
        Operadores de comparación
        == -> Igual a
        != -> No es igual
        >  -> Mayor que
        <  -> Menor que
        >= -> Mayor o igual
        <= -> Menor o igual

        Operadores lógicos
        &  -> AND
        && -> AND short circuit
        |  -> OR
        || -> OR short circuit
        !  -> NOT
        ^  -> XOR
         */
        static void Main(string[] args)
        {
            //PruebaOperadoresAritmeticos();
            //EncontrarNumerosImpares();
            //OperadoresDeAsignacion();
            Iteraciones();
            Console.WriteLine("Presione [ENTER] para finalizar...");
            Console.ReadLine();
        }
        static void PruebaOperadoresAritmeticos()
        {
            double valor1, valor2, resultado = 0;
            string operacion;
            string menu = "Escriba la operacion que desea realizar: \n"
                + "suma \n"
                + "resta \n"
                + "multiplicación \n"
                + "division";
            Console.WriteLine(menu);
            operacion = Console.ReadLine();
            Console.WriteLine("Escriba la primera cantidad");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la segunda cantidad");
            valor2 = double.Parse(Console.ReadLine());
            if (operacion == "suma")
            {
                resultado = valor1 + valor2;
            }
            else if (operacion == "resta")
            {
                resultado = valor1 - valor2;
            }
            else if (operacion == "division")
            {
                resultado = valor1 / valor2;
            }
            else if (operacion == "multiplicacion")
            {
                resultado = valor1 * valor2;
            }
            else
            {
                Console.WriteLine("Operacion no soportada");
            }
            Console.WriteLine($"Resultado: {resultado}");
        }
        static void EncontrarNumerosImpares()
        {
            int limite;
            Console.WriteLine("Escriba un numero que represente el limite para encontrar numero impares");
            limite = int.Parse(Console.ReadLine());
            for(int contador = 1; contador <= limite;contador++)
            {
                if(contador % 2 !=0)
                {
                    Console.WriteLine(contador);
                }
            }
        }
        static void OperadoresDeAsignacion()
        {
            double a=5, b=7,c;
            // var ++ post increment
            a++; // el valor de a será 6
            a--; // el valor de a será 5
            // ++ var pre increment
            ++a; // el valor de a será 6
            --a; // el valor de a será 5

            c = a + b;
            Console.WriteLine($"c = a+b ={c}");
            c = a++;
            Console.WriteLine($"c = a++ ={c}");
            c = ++a;
            Console.WriteLine($"c = ++a ={c}");

            /*
            +=
            -=
            *=
            /=
             */
            a = a + 2;
            a += 2;
            a = a - 2;
            a -= 2;
        }
        static void VendingMachine()
        {
            Console.WriteLine("Escriba el numero de producto que desea comprar");
            Console.WriteLine("1. Cafe clasico \n2. Espresso \n3. Capuccino \n4. Latte");
            string eleccion = Console.ReadLine();
            double precio;
            switch (eleccion)
            {
                case "1":
                    precio = 25;
                    break;
                case "2":
                    precio = 30;
                    break;
                case "3":
                    precio = 45;
                    break;
                case "4":
                    precio = 40;
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    precio = 0;
                    break;
            }
            Console.WriteLine($"Total a pagar: {precio}");
        }

        static void Iteraciones()
        {
            int contador = 1;
            do
            {
                Console.WriteLine($"Ejecucion {contador}");
                contador++;
            } while (contador <= 10);
            
            while (contador > 0)
            {
                Console.WriteLine($"Ejecucion {contador}");
                contador--;
            }

            // break
            while (true)
            {
                Console.WriteLine($"Ejecucion {contador}");
                contador++;
                if (contador == 10)
                {
                    break;
                }
            }
            // continue
            Console.WriteLine("Numero pares entre 11 y 20");
            while (contador <= 20)
            {
                contador += 1;
                if (contador % 2 != 0) continue;
                Console.WriteLine(contador);
                
            }
        }
    }
}
