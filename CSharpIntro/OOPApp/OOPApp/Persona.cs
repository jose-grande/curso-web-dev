using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp
{
    public class Persona
    {
        //public string Direccion;
        //fields
        // [access-modifier] <data-type> <identifier>; 
        private string _nombre;
        //properties
        public string Nombre
        {
            get { return _nombre; }
            set {
                Console.WriteLine("El valor de la propiedad Nombre esta siendo modificado");
                _nombre = value; 
            }
        }
        private string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        // auto-implemented property
        public DateTime FechaNacimiento { get; set; }
        // read-only
        public int Edad
        {
            get
            {
                return (DateTime.Now - FechaNacimiento).Days / 365;
            }
        }

        //methods
        //[acces-modifier] <data-type> <identifier>([ars..])
        public void Imprimir()
        {
            string texto = $"Nombre: {this.Nombre}; Apellido: {this._apellido}; Edad: {Edad}";
            Console.WriteLine(texto);
        }
        public string ObtenerNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }
        public string Exportar(string separador)
        {
            var resultado = $"{Nombre}{separador}{Apellido}{separador}{Edad}";
            //var numero=5;
            return resultado;
        }

        //constructors
        public Persona()
        {
            FechaNacimiento = DateTime.Now;
        }
        // constructors overload
        public Persona(string nombre, string apellido, DateTime FechaNacimiento)
        {
            this.Nombre= nombre;
            Apellido = apellido;
            this.FechaNacimiento = FechaNacimiento;
        }
    }
}
