using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp
{
    public delegate void NotificarCambios(string mensaje);
    public class Empleado
    {
        public event NotificarCambios EmpleadoModificado;
        public int Identificador { get; set; }
        private double _salario;
        public double Salario
        {
            get { return _salario; }
            set { 
                _salario = value;
                if (EmpleadoModificado != null) {
                    EmpleadoModificado($"El salario fue modificado a {value}");
                }
            }
        }
        private int _vacacionesPednientes;
        public int VacacionesPendientes
        {
            get { return _vacacionesPednientes; }
            set { 
                _vacacionesPednientes = value;
                if (EmpleadoModificado != null)
                {
                    EmpleadoModificado($"Las vacaciones pendientes fueron modificadas a {value}");
                }
            }
        }

    }
}
