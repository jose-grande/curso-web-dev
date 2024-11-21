using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace DotNetFundamentals
{
    public class ThreadUtilities
    {
        public static void ContarHasta100()
        {
            var contador = 0;
            do
            {
                Thread.Sleep(50);
                contador++;

            } while (contador <= 100);
            Console.WriteLine("Ha finalizado la cuenta");
        }
    }
}
