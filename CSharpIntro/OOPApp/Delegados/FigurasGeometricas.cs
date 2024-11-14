using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate bool CompararFigura(FiguraGeometrica figura);
    public class FigurasGeometricas
    {
        private FiguraGeometrica[] _figuras = new FiguraGeometrica[10];
        private int _index = 0;

        public void Agregar(FiguraGeometrica figura) {
            this._figuras[_index++] = figura;
        }
        public void Filtrar(CompararFigura comparar)
        {   
            for (int i = 0; i < _index; i++)
            {
                if (comparar(this._figuras[i]))
                {
                    Console.WriteLine($"Alto: {this._figuras[i].Alto}; Ancho: {this._figuras[i].Ancho}");
                }
            }
        }
    }
}
