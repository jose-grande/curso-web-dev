using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //1. Agregar la funcionalidad requerida para que esta coleccion pueda ser utilizada en un foreach
    //2. Agregar la funcional requeridad para que esta coleccion pueda crecer en demanda cuando sea requerido
    //3. Crear una aplicacion de ejemplo que permita calcular estadisticas utilizando esta clase
    //4. Investigar al menos 2 tipos de datos genericos de .Net
    public class ColeccionGenerica<T>
    {
        private T[] objects;
        private int currentIndex;
        public ColeccionGenerica()
        {
            objects = new T[10];
            currentIndex = 0;
        }
        public void Agregar(T obj)
        {
            objects[currentIndex++] = obj;
        }
        public int ObtenerIndice(T obj)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (obj.Equals(objects[i])) return i;
            }
            return -1;
        }
        public void Eliminar(T obj)
        {
            var index = ObtenerIndice(obj);
            objects[index] = default(T);
            if (index < objects.Length - 1)
            {
                for (int x = index; x < objects.Length - 1; x++)
                {
                    objects[x] = objects[x + 1];
                }
            }
        }
        public T ObtenerElemento(int index)
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
