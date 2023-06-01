// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

Console.WriteLine("valor de a:"+a);

Console.WriteLine("valor de b:"+b);

//EJERCICIO 1
int num=0;
string s = "245";

if (!int.TryParse(s, out num))
{
Console.WriteLine("valor ingresado no es un numero valido"); 
}else{
    int invertido=0;
    Console.WriteLine("Valor de num: "+num);

    while(num>0){
        invertido = invertido * 10 + num % 10;
        num /= 10;
    }
    Console.WriteLine("Valor invertido: "+invertido);
}

//EJERCICIO 4
Console.WriteLine();
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena = Console.ReadLine();

//Longitud 
int longitud = cadena.Length;
Console.WriteLine("La longitud de la cadena es: "+longitud);

//concatenar con otra cadena
Console.WriteLine("Ingrese otra cadena de texto: ");
string cadena2 = Console.ReadLine();
string concatenada = cadena + cadena2;
Console.WriteLine("La concatenacion es: "+concatenada);

//Extraer una subcadena de la cadena ingresada
Console.WriteLine("Ingrese el indice de inicio para la subcadena: ");
int indiceInicio = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la longitud de la subcadena:");
int longitudSubcadena = int.Parse(Console.ReadLine());
string subcadena = cadena.Substring(indiceInicio, longitudSubcadena);
Console.WriteLine("La subcadena extraída es: " + subcadena);

//calculadora
int valor=0, num1, num2, suma, resta, mult, divi;
Console.WriteLine("(1)Suma");
Console.WriteLine("(2)Resta");
Console.WriteLine("(3)Multiplicar");
Console.WriteLine("(4)Dividir");
Console.WriteLine("Ingrese un valor: ");
if (!int.TryParse(Console.ReadLine(), out valor))
{
    Console.WriteLine("El valor ingresado no es valido");
    return;
}else{
Console.WriteLine("Valor ingresado: "+valor);
}
Console.WriteLine("\nPrimer numero: ");
if (!int.TryParse(Console.ReadLine(),out num1))
{
    Console.WriteLine("El valor ingresado no es valido");
    return; 
}else{
    Console.WriteLine("Segundo numero: ");
    if (!int.TryParse(Console.ReadLine(),out num2))
    {
        Console.WriteLine("El valor ingresado no es valido");
       return;
    }else{
        
        int resp;
        do
        {
            switch (valor)
        {
            case 1:
            suma = num1 + num2;
            string sumacad = suma.ToString();
            Console.WriteLine("Resultado: "+sumacad);
            break;
            case 2:
            resta = num1 - num2;
            string restacad = resta.ToString();
            Console.WriteLine("Resultado: "+restacad);
            break;
            case 3:
            mult = num1 * num2;
            string multcad = mult.ToString();
            Console.WriteLine("Resultado: "+multcad);
            break;
            case 4:
            divi = num1 / num2;
            string divcad = divi.ToString();
            Console.WriteLine("Resultado: "+divcad);
            break;

            default:

            break;
        }

        Console.WriteLine("Realizar otra operacion SI(1) No(0): ");
        if (!int.TryParse(Console.ReadLine(), out resp))
        {
            Console.WriteLine("El valor ingresado no es valido");
            return;
        }else{
            if(resp == 1){
                    Console.WriteLine("(1)Suma");
                    Console.WriteLine("(2)Resta");
                    Console.WriteLine("(3)Multiplicar");
                    Console.WriteLine("(4)Dividir");
                    Console.WriteLine("Ingrese un valor: ");
                    if (!int.TryParse(Console.ReadLine(), out valor))
                    {
                           Console.WriteLine("El valor ingresado no es valido");
                          return;
                    }
            }

        } 
        } while (resp != 0);

    }
}

// Recorrer la cadena de texto con un ciclo foreach
Console.WriteLine("Recorriendo la cadena de texto:");
foreach (char caracter in cadena)
{
Console.WriteLine(caracter);
}

// Buscar la ocurrencia de una palabra determinada en la cadena
Console.WriteLine("Ingrese una palabra a buscar en la cadena:");
string palabraBuscada = Console.ReadLine();
bool palabraEncontrada = cadena.Contains(palabraBuscada);
Console.WriteLine("La palabra buscada se encontró en la cadena: " + palabraEncontrada);

// Convertir la cadena a mayúsculas y luego a minúsculas
string mayusculas = cadena.ToUpper();
string minusculas = cadena.ToLower();
Console.WriteLine("La cadena en mayúsculas es: " + mayusculas);
Console.WriteLine("La cadena en minúsculas es: " + minusculas);

// Dividir la cadena utilizando caracteres específicos
Console.WriteLine("Ingrese una cadena separada por caracteres:");
string cadenaSeparada = Console.ReadLine();
string[] partes = cadenaSeparada.Split(',');
Console.WriteLine("Resultados:");
foreach (string parte in partes)
{
Console.WriteLine(parte);
}

// Resolver una ecuación simple ingresada como cadena de caracteres
Console.WriteLine("Ingrese una ecuación simple (ejemplo: 582+2):");
string ecuacion = Console.ReadLine();
string[] numeros = ecuacion.Split('+');
double resultadoEcuacion = double.Parse(numeros[0]) + double.Parse(numeros[1]);
Console.WriteLine("El resultado de la ecuación es: " + resultadoEcuacion);