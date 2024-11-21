using Polimorfismo;
using System.Collections.Generic;
using Estadisticas;

Cuadrado cuadrado = new Cuadrado(200, 200, "px");
cuadrado.Imprimir();

//Empleado emp1 = new Empleado();

EmpleadoPermanente permanente1 = new EmpleadoPermanente();
Empleado emp2 = new EmpleadoPermanente();
Object obj1 = new FiguraGeometrica();

//IPlanillaService service = new PlanillaService();
IPlanillaService service = new BDPlanillaService();
Coleccion numeros= new Coleccion();
numeros.Agregar(15);
numeros.Agregar(20);

for (int i = 0; i < numeros.Longitud; i++)
{
    Console.WriteLine(numeros.ObtenerElemento(i));
}
double suma = 0;
for (int i = 0; i < numeros.Longitud; i++)
{
    //unboxing
    suma+=(double)numeros.ObtenerElemento(i);
}

ColeccionGenerica<double> nums=new ColeccionGenerica<double>();
nums.Agregar(50);
nums.Agregar(100);
nums.Agregar(20);
suma=0;
for (int i = 0;i < nums.Longitud; i++)
{
    suma += nums.ObtenerElemento(i);
}
/*
    Tipos de datos genericos en .Net
 */

// coleccion no ordenada
List<double> doubles=new List<double>();
doubles.Add(50);doubles.Add(100);doubles.Add(20);
suma=0;
for(int i = 0; i < doubles.Count; i++)
{
    suma += doubles[i];
}
suma = 0;
foreach(double d in doubles)
{
    suma+=d;
}
string[] nombres = ["Julio", "Ana", "Maria", "Pedro"];
foreach(var nombre in nombres)
{
    Console.WriteLine(nombre);
}
// diccionario
Dictionary<int, EmpleadoPermanente> empleados = new Dictionary<int, EmpleadoPermanente>();
empleados.Add(1, new EmpleadoPermanente { Nombre = "Pedro", Apellido = "Perez", SalarioBase = 6000 });
empleados.Add(2, new EmpleadoPermanente { Nombre = "Maria", Apellido = "Salazar", SalarioBase = 6000 });
empleados.Add(3, new EmpleadoPermanente { Nombre = "Julio", Apellido = "Gonzales", SalarioBase = 6000 });
foreach(var emp in empleados)
{
    Console.WriteLine(emp.Value.ToCSV());
}
empleados.Remove(2);

var promedio = EstadisticasGenerales.Promedio([123, 456, 789]);


ColeccionGenerica<int> numsCol=new ColeccionGenerica<int>();
numsCol.Agregar(123); nums.Agregar(456); nums.Agregar(789);
int sumCol = 0;
foreach(var n in numsCol)
{
    sumCol += n;
}
var promCol = sumCol / numsCol.Longitud;