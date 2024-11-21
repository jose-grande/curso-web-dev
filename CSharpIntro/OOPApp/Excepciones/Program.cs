// See https://aka.ms/new-console-template for more information
using Excepciones;

Console.WriteLine("Esta calculadora permite realizar operaciones con 2 numeros");
int cant1,cant2;
Console.WriteLine("Escriba la primera cantidad");
try
{
    cant1 = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch(OverflowException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Ha ocurrido un error inesperado.");
}

Console.WriteLine("Escriba la seguna cantidad");
try
{
    cant2 = Capturador.LeerEntero();
}
catch (Exception ex)
{

    Console.WriteLine("Ha ocurrido un error inesperado.");
}


