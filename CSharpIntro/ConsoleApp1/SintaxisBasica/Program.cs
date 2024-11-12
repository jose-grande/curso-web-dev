// See https://aka.ms/new-console-template for more information
// Strong typed
Console.WriteLine("Hola, Sintaxis Basica!");

/*
    <data-type> <identifier>;
    <data-type> <identifier>=<value>;
    <data-type> <identifier1>, <identifier2>;
 */
int numero;
int numero2 = 15;
int numero3,numero4;

/* char */
char letra = 'a';

/* string */
string texto = "Esta es una cadena de texto";

/* bool */

bool respuesta = true; // false

/* double */
double valor = 5.5;

/* decimal */
decimal valor2 = 10.4M;

/* DateTime */
DateTime fecha = new DateTime(2024, 01, 01);

/* object */
object variable = 85.5;
variable = "texto";

/*
    const <date-type> <identifier>=<value>;
 */
const double PI=3.14159;

/*
    Conversiones
 */

int entero32 = 2147483647;
long entero64 = 2147483648555;

// Conversion implicita
entero64 = entero32;

// Aqui se pierde precision
//entero32 = entero64;

long identificador1 = 1;
// Conversion explicita
int identificador2 = Convert.ToInt32(identificador1);

string cantidad = "654.21";
decimal cantidadDecimal=Convert.ToDecimal(cantidad);

// Cast - casting
object nota = "Aqui hay una nota de texto";
string notaTexto = (string)nota;

object valorDecimal = 951.2M;
decimal ultValorDecimal = (decimal)valorDecimal;

long enteroLargo = 5;
int enteroCorto = (int)enteroLargo;

// este casting no funciona
string numeroComoTexto = "3335.2";
//decimal textoComoDecimal = (decimal)numeroComoTexto;

object objNumeroComoTexto = "35432132";
decimal textoComoDecimal = (decimal)objNumeroComoTexto;