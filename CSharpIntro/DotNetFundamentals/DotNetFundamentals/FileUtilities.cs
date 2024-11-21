using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace DotNetFundamentals
{
    public class FileUtilities
    {
        public static void LeerDirectorio(string ruta)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(ruta);
            if (directoryInfo.Exists)
            {
                foreach (FileInfo item in directoryInfo.EnumerateFiles())
                {
                    //Console.WriteLine(item.FullName);
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                Console.WriteLine("El directorio no se encontró");
                Console.WriteLine("Desea crearlo? (S/n)");
                var respuesta = Console.ReadLine();
                if (respuesta != "S")
                {
                    directoryInfo.Create();
                }
            }
        }
        public static void LeerDirectorioV2(string ruta)
        {
            if (Directory.Exists(ruta))
            {
                foreach (string file in Directory.GetFileSystemEntries(ruta))
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("El directorio no se encontró");
                Console.WriteLine("Desea crearlo? (S/n)");
                var respuesta = Console.ReadLine();
                if (respuesta != "S")
                {
                    Directory.CreateDirectory(ruta);
                }
            }
        }
        public static void CrearArchivoTexto(string ruta, string texto)
        {
            if (File.Exists(ruta))
            {
                Console.WriteLine("El archivo ya existe");
                return;
            }
            File.WriteAllText(ruta, texto);
        }
        public static void CrearArchivoTexto(string ruta, string[] contenido)
        {
            StreamWriter stream = new StreamWriter(ruta, true);
            for (int i = 0; i < contenido.Length; i++)
            {
                stream.Write(contenido[i] + "\n");
            }
            stream.Close();
            stream.Dispose(); // libera la memoria
        }
        public static void CrearArchivoTextoV2(string ruta, string[] contenido)
        {
            using (StreamWriter stream = new StreamWriter(ruta, true))
            {
                for (int i = 0; i < contenido.Length; i++)
                {
                    stream.Write(contenido[i] + "\n");
                }
            }
        }
        public static void LeerArchivoTexto(string ruta)
        {
            if (File.Exists(ruta))
            {
                string texto = File.ReadAllText(ruta);
                //File.ReadAllBytes(texto);
                Console.WriteLine(texto);
            }
            else { Console.WriteLine("El archivo no existe"); }
        }
        public static void LeerArchivoTextoV2(string ruta)
        {
            using (StreamReader stream = new StreamReader(ruta))
            {
                char[] buffer= new char[1024];
                int cuenta = stream.Read(buffer, 0, 1024);
                Console.WriteLine($"Numero de caracteres: {cuenta}");
                Console.WriteLine(buffer);
            }
        }
    }
}
