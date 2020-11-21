using System;

namespace PrototypeShallow
{
    class Program
    {
        static void Main(string[] args)
        {
            SerVivo SV = new SerVivo();
            SV.tipo = "Planta";

            SerVivo SVClon = SV.Clone() as SerVivo;
            SVClon.tipo = "Humano";


            Console.WriteLine("Tipo : "+ SV.tipo);
            Console.WriteLine("CLON Tipo : "+SVClon.tipo);

            Console.ReadKey();
        }
    }
}
