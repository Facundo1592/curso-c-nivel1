class Program
{
    static void Main(string[] args)

    {

        int numero1, numero2, numero3, numero4;
        //4.Hacer un programa para ingresar tres números y
        //emitir un cartel aclaratorio si la
        //suma de los dos primeros es mayor al
        // producto del segundo con el tercero.

        // pedir numeros
        Console.WriteLine("ingrese un numero:");
        numero1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese el segundo numero:");
        numero2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese el tercero numero:");
        numero3 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese el ultimo numero:");
        numero4 = int.Parse(Console.ReadLine()!);



        if (numero1 > numero2 && numero2 > numero3 && numero3 > numero4)
        {
            //numero1 > numero2 && numero3 && numero3 > numero4;
            Console.WriteLine("Los numeros  estan oredenados ");
        }
        else
        {

            Console.WriteLine("Los numeros no estan oredenados  ");

        }





    }
}