class Program
{
    static void Main(string[] args)

    {


        // variables
        int n1, n2, n3, n4;



        Console.WriteLine("ingrese un numero");

        // ingreso de numeros
        n1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese un otro");
        n2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese otro");
        n3 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese un ultimo");
        n4 = int.Parse(Console.ReadLine()!);

        if (n1 > n2)
        {
            //importeFinal = importe * 0.82m; // Aplica 18% de descuento
            Console.WriteLine("el mayor es:" + n1);
        }
        else if (n2 > n3)
        {
            //importeFinal = importe * 0.90m; // Aplica 10% de descuento
            Console.WriteLine("el mayor es:" + n2);
        }

        else if (n3 > n4)
        {
            //importeFinal = importe; // sin descunetos
            Console.WriteLine("el mayor es:" + n3);
        }

        else
        {
            Console.WriteLine("el mayor es:" + n4);
        }


        //4. Hacer un programa para
        //ingresar cuatro números distintos y
        // luego mostrar
        //por pantalla el menor de ellos.


        // otra solucion
        // variables
        //int n1, n2, n3, n4, menor;

        //Console.WriteLine("Ingrese cuatro números distintos:");

        // Ingreso de números
        //n1 = int.Parse(Console.ReadLine()!);
        //n2 = int.Parse(Console.ReadLine()!);
        //n3 = int.Parse(Console.ReadLine()!);
        //n4 = int.Parse(Console.ReadLine()!);

        // Encontrar el menor
        //menor = n1; // Asumimos que el primero es el menor

        //if (n2 < menor)
        //menor = n2;

        //if (n3 < menor)
        //menor = n3;

        //if (n4 < menor)
        //menor = n4;

        //Console.WriteLine("El menor es: " + menor);

    }

}