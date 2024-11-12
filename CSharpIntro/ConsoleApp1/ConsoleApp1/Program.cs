// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Rellene el siguiente formulario");

Console.WriteLine("Escriba su nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("Fecha de nacimiento (dd-MM-yyyy):");
//DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
DateTime fechaNacimiento = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",CultureInfo.InvariantCulture);

Console.WriteLine("Escriba aspiracion salarial");
decimal salario = decimal.Parse(Console.ReadLine());

//Console.WriteLine("Nombre: " + nombre + "; Fecha Nacimiento: " + fechaNacimiento);

// Text interpolation
Console.WriteLine($"Nombre: {nombre}; Fecha de nacimiento: {fechaNacimiento}; Salario: {salario}");

Console.WriteLine("Presione [Enter] para finalizar");
Console.ReadLine();