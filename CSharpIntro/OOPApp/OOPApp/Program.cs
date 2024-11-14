//int variable = 4;
// objeto
using OOPApp;

Persona per1;//null
//llamado al constructor
per1 = new Persona();

per1.Nombre = "Juan";
per1.Apellido = "Gonzales";
per1.FechaNacimiento = new DateTime(1990,1,1);
//per1.Edad = 25;

//Console.WriteLine($"Nombre: {per1.Nombre}; Edad: {per1.Edad}");
per1.Imprimir();

Console.WriteLine("Imprimiendo datos separados por coma");
var datosSeparados = per1.Exportar(",");
Console.WriteLine(datosSeparados);

Persona per2 = new Persona("Maria", "Flores", new DateTime(2000,1,1));
per2.Imprimir();

//Estadisticas estadisticas=new Estadisticas();
//estadisticas.Sumar(500, 600);
Estadisticas.Sumar(500, 600);
Estadisticas.Sumar([50, 60, 20]);
Math.Max(500, 600);
Console.WriteLine($"PI={Estadisticas.PI}");
Console.WriteLine($"e={Estadisticas.e}");
Console.WriteLine($"Ultimo resultado: {Estadisticas.UltimoResultado}");
Estadisticas.Promedio(55,33,66,99,44);

void Emp1_EmpleadoModificado(string texto)
{
    Console.WriteLine(texto);
}
Empleado emp1= new Empleado();
emp1.EmpleadoModificado += Emp1_EmpleadoModificado;
emp1.EmpleadoModificado += Console.WriteLine;
emp1.Salario = 5000;

