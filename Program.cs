using System;

namespace Condicion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            string linea = Console.ReadLine();
            int numero = int.Parse(linea);

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else
            {
                if (numero < 0)
                {
                    Console.WriteLine("El número es negativo");
                }
                else
                {
                    Console.WriteLine("El número es cero");
                }
            }

            Console.ReadKey();
        }
    }
}
