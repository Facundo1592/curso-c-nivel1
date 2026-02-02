// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
        {
            // ARS15000 más una comisión del 5% sobre el total facturado por 
            // cada empleado.
            //   Una casa de computación paga a sus empleados un sueldo fijo de 
            //   Hacer un programa para ingresar el total facturado por un 
            // empleado y que luego 
            //  calcule y 
            // emita por pantalla el sueldo total a cobrar por el mismo.

           // sueldo fijo 15000 comicion sobre el total facturado

          //variables y variable constante
            float totalFacturado ,comision ,sueldoFinal;
            const float sueldoFijo = 15000;
            const float porcentajeComision = 0.05F;

            // pedir kilometraje 
            Console.WriteLine("ingrese el total facturado:");
            totalFacturado = float.Parse(Console.ReadLine()!);
        

          // mostrar resultado de la comision
          comision = totalFacturado * porcentajeComision;

           // mostrar resultado del sueldo final

           sueldoFinal =comision + sueldoFijo;
            Console.WriteLine("El sueldo a pagar es: " + sueldoFinal);
        }
    } 
    