using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton Ejemplo1 = Singleton.Validacion();

            Singleton Ejemplo2 = Singleton.Validacion();


            Console.WriteLine("10 Dolares en peso = "+Ejemplo1);
            Console.WriteLine(Ejemplo2);

            if(Ejemplo1 == Ejemplo2)
            {
                Console.WriteLine("Funciona");
            }
            Console.ReadKey();

            
        }
    }
}
