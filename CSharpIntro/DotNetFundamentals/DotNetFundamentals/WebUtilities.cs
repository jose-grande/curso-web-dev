using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFundamentals
{
    public class WebUtilities
    {
        public static void ObtenerCoordenaadas(string ciudad)
        {
            //https://geocode.xyz
            var url = $"https://geocode.xyz/{ciudad}?json=1";
            HttpClient client = new HttpClient();
            HttpResponseMessage result = client.GetAsync(url).Result;
            if (result.StatusCode == System.Net.HttpStatusCode.OK) 
            {
                string contenido = result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(contenido);
            }
        }
    }
}
