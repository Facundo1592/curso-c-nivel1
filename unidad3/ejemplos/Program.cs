// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        // Bloque if : condicionales. 
        // //operadores relacionales
        //  //> < <= >= == !=
        //  // valor op valor //n1 > 10 
        // // 10 > 5 esto noo
        
    
        
        int edad = 20;



        // IF simple
        if (edad > 21)
        {
            Console.WriteLine("21 off");
        }
        else
        {
            Console.WriteLine("f10 off");
        }

        Console.WriteLine("fin al if");



        // ELSE IF
        if (edad > 30)
        {
            Console.WriteLine("30 off");
        }
        else if (edad > 20)
        {
            Console.WriteLine("21 off");
        }
        else if (edad == 18)
        {
            Console.WriteLine("10 off");
        }
        else
        {
            Console.WriteLine("5 off");
        }

        Console.WriteLine("fin al if");



        // IF anidado
        if (edad > 20)
        {
            if (edad > 30)
            {
                Console.WriteLine("30 off");
            }
            else
            {
                Console.WriteLine("21 off");
            }
        }
        else
        {
            Console.WriteLine("f10 off");
        }

        Console.WriteLine("fin al if");




        // acumuladores y ncontadores 

        
    }
}
