class Program
{
    static void Main(string[] args)

    {
        // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo
        //ide la cantidad de litros vendidos según la siguiente escala:

        // Si vende menos de 100 litros, no hay descuento.
        //Si vende entre 101 y 300 litros, el descuento es del 10%.
        //Si vende entre 301 y 500 litros, el descuento es del 15%.
        //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.  
        float importe, litros, importeFinal = 0;


        // pedir montos
        Console.WriteLine("importe total:");
        importe = float.Parse(Console.ReadLine()!);
        // pedir litros 
        Console.WriteLine("cantidad de litros vendidos:");
        litros = float.Parse(Console.ReadLine()!);





        if (litros <= 100)
        {

            importeFinal = importe;// no hay descuento.
            {

                importeFinal = importe * 0.90f;// el descuento es del 10%.
            }

            if (litros > 300 && litros <= 500)
            {


                importeFinal = importe * 0.85f;//descuento es del 15%.
            }
            if (litros > 500)
            {


                importeFinal = importe * 0.75f; // descuento es del 25%.
            }


            Console.WriteLine("el importeFinal :" + importeFinal);

        }

    }
}