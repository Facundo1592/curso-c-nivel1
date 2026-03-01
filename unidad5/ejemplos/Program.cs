using System.Diagnostics;

class Program
{
    static void Main(string[] args)

    {


        //CICLO FOR
        //inicializacion-condicion- incremento
        //  for(int X = 0; X < 5; X++)
        // {
        //      Console.WriteLine("HOLA MUNDO");
        // }
        /*
        int n = 0, promedio, suma = 0;

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("ingrese la nota");
            n = int.Parse(Console.ReadLine()!);
            suma = suma + n;
            //suma += n;

        }
        promedio = suma / 5;
        Console.WriteLine("el promedio de nota es:" + promedio);
        */
        /*

        // ciclo while

        int n, con = 0;
        Console.WriteLine("ingrese un nros");
        n = int.Parse(Console.ReadLine()!);

        while (n != 0)
        {
            con++;
            Console.WriteLine("ingrese un nros");
            n = int.Parse(Console.ReadLine()!);

        }
        Console.WriteLine("ingresaste :" + con + "nros.");
        */
        //do while

        int n, con = 0;
        do
        {
            Console.WriteLine("ingrese la nota");
            n = int.Parse(Console.ReadLine()!);
            con++;

        } while (n != 0);
        Console.WriteLine("ingresaste :" + con + "nros.");
















    }

}