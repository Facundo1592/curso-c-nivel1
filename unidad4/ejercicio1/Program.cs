
class Program
{
    static void Main(string[] args)

    {
        // 1. Hacer un programa que solicite el 
        //ingreso de dos números y luego calcular:

        // La resta si el primero es mayor que el segundo.
        // La suma si son iguales.
        //El producto si el primero es menor.
        // Se deberá emitir un cartel por pantalla con el resultado correspondiente.

        int A, B, resultado = 0;  // se inicializa en 0 para evitar que guarde basura
        Console.WriteLine("ingrese un numero");
        A = int.Parse(Console.ReadLine()!);
        Console.WriteLine("ingrese otro numero");
        B = int.Parse(Console.ReadLine()!);

        if (A > B)
        {
            // Console.WriteLine(A - B);
            resultado = A - B;
        }
        if (A == B)
        {
            // Console.WriteLine(A + B); no esta mal , muestra el resu previo
            resultado = A + B;
        }

        if (A < B)
        {

            //Console.WriteLine(A * B);
            resultado = A * B;

        }


        Console.WriteLine("el resultado es:" + resultado);

    }

}