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

//EJERCICIO 3
double N;
Console.WriteLine();
Console.WriteLine("Ingrese un numero: ");
if (!double.TryParse(Console.ReadLine(), out N))
{
    Console.WriteLine("El valor ingresado no es valido");
    return;
}else{
    Console.WriteLine("Valor ingresado: "+N);
    Console.WriteLine("RESULTADOS");
    //Valor absoluto
    double valorAbsoluto = Math.Abs(N);
    Console.WriteLine("Valor Absoluto: "+valorAbsoluto);
    //Cuadrado
    double cuadrado = Math.Pow(N, 2);
    Console.WriteLine("Cuadrado: "+cuadrado);
    //Raiz cuadrada
    double raizCuadrada = Math.Sqrt(N);
    Console.WriteLine("Raiz cuadrad: "+raizCuadrada);
    //Seno
    double seno = Math.Sin(N);
    Console.WriteLine("Seno: "+seno);
    //Conseno
    double coseno = Math.Cos(N);
    Console.WriteLine("Coseno: "+coseno);
    //Parte entera de un tipo float
    double parteEntera = Math.Truncate(N);
    Console.WriteLine("Parte entera: "+parteEntera);
}

Console.WriteLine();
Console.WriteLine("Ingrese primer numero: ");
if (!double.TryParse(Console.ReadLine(), out double N1))
{
     Console.WriteLine("El valor ingresado no es valido");
    return;
}
Console.WriteLine("Ingrese segundo numero: ");
if (!double.TryParse(Console.ReadLine(), out double N2))
{
     Console.WriteLine("El valor ingresado no es valido");
    return;
}

double maximo = Math.Max(N1,N2);
Console.WriteLine("El maximo es: "+maximo);
double minimo = Math.Min(N1,N2);
Console.WriteLine("El minimo es: "+minimo);




