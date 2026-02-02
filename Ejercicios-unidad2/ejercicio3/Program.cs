// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que permita ingresar los kilómetros 
       //existentes entre dos ciudades y la velocidad promedio de un vehículo. 
       //Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un 
      // punto a otro teniendo en cuenta los datos ingresados.

          //variables
       float kilometros, velocidad , tiempo;
    
       // pedir kilometraje 
       Console.WriteLine("ingrese la distacia:");
       kilometros = float.Parse(Console.ReadLine()!);
       // pedir velocidad 
        Console.WriteLine("ingrese la velocidad promedio:");
        velocidad = float.Parse(Console.ReadLine()!);

        // utilize los signos para que entienda el compilador !!

       // mostrar resultado

       tiempo = kilometros / velocidad;
        Console.WriteLine("El tiempo sera de: " + tiempo.ToString("0.00") + " horas" );
    }
}
