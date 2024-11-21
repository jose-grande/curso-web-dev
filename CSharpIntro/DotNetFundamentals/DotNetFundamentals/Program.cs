// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.IO;
using DotNetFundamentals;

//string directorioActual=Assembly.GetExecutingAssembly().Location;
string directorioActual=Directory.GetCurrentDirectory();

FileUtilities.LeerDirectorio(directorioActual);

string nombreArchivo = Path.Combine(directorioActual, "texto.txt");

FileUtilities.CrearArchivoTexto(nombreArchivo, "Hola mudo!!");

string contactos = Path.Combine(directorioActual, "contactos.txt");

//string[] personas = ["Juan", "Maria","Pedro"];
//FileUtilities.CrearArchivoTexto(contactos,personas);


FileUtilities.LeerArchivoTexto(contactos);
FileUtilities.LeerArchivoTextoV2(contactos);

Thread t1 = new Thread(ThreadUtilities.ContarHasta100);
//ThreadUtilities.ContarHasta100();
t1.Start();

WebUtilities.ObtenerCoordenaadas("Tegucigalpa");

t1.Join(); // permitira que se una al hilo principal