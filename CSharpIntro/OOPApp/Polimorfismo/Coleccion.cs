using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Coleccion
    {
        private object[] objects;
        private int currentIndex;
        public Coleccion()
        {
            objects = new object[10];
            currentIndex = 0;
        }
        public void Agregar(object obj)
        {
            objects[currentIndex++] = obj;
        }
        public int ObtenerIndice(object obj)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (obj == objects[i]) return i;
            }
            return -1;
        }
        public void Eliminar(object obj)
        {
            var index = ObtenerIndice(obj);
            objects[index] = null;
            if (index < objects.Length - 1)
            {
                for (int x = index; x < objects.Length - 1; x++)
                {
                    objects[x] = objects[x + 1];
                }
            }
        }
        public object[] Elementos
        {
            get
            {
                var copia=new object[currentIndex];
                for (int x = 0; x <= currentIndex; x++)
                {
                    copia[x] = objects[x];
                }
                return copia;
            }

        }
        public object ObtenerElemento(int index)
        {
            return objects[index];
        }
        public int Longitud
        {
            get
            {
                return currentIndex + 1;
            }
        }
    }
}
