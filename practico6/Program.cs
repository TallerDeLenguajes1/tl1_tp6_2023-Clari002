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

