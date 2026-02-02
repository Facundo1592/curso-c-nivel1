// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
       //Hacer un programa para solicitar por teclado
       //  un número y luego devolver su valor elevado al cubo.

       int n ,cubo;
       // pedir nro
       Console.WriteLine("ingrese un nro:");
       n = int.Parse(Console.ReadLine());
       // elevar al cubo
       cubo =  n * n * n;
       
       // mostrar resultado
        Console.WriteLine("El resultado de elevar " + n + " al cubo es:" + cubo);
    }
}
