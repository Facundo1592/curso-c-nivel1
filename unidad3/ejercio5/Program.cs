using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)

    {
        //5. Hacer un programa para ingresar cuatro números 
        //y luego mostrar por pantalla cuáles son mayores a 100.




        // variables
        int n1, n2, n3, n4, numero, con = 0;

        numero = 100;



        Console.WriteLine("ingrese un numero");

        // ingreso de numeros
        n1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese un otro");
        n2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese otro");
        n3 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese un ultimo");
        n4 = int.Parse(Console.ReadLine()!);

        // condicionales 

        if (n1 > numero)// evalua el primer numero
        {
            Console.WriteLine(n1);
            con++;
        }

        if (n2 > numero)// evalua el primer segundo
        {
            Console.WriteLine(n2);
            con++;
        }
        if (n3 > numero)// evalua el primer tercero 
        {
            Console.WriteLine(n3);
            con++;
        }
        if (n4 > numero)// evalua el primer ultimo
        {
            Console.WriteLine(n4);
            con++;
        }

        if (con != 0) // practicando con el contador 

        {
            Console.WriteLine("son los mayores a 100");
        }



        Console.WriteLine("fin del programa");






    }

}