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

//EJERCICIO 2
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
            Console.WriteLine("Resultado: "+suma);
            break;
            case 2:
            resta = num1 - num2;
            Console.WriteLine("Resultado: "+resta);
            break;
            case 3:
            mult = num1 * num2;
            Console.WriteLine("Resultado: "+mult);
            break;
            case 4:
            divi = num1 / num2;
            Console.WriteLine("Resultado: "+divi);
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

