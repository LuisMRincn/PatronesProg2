using System;

namespace PatronComand
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mandato;
            Escavadora escavadora = new Escavadora();
            MandatosOfficiales MOficiales = new MandatosOfficiales(escavadora);

            do
            {
                Console.WriteLine("Encender - 1 \nApagar - 2");
                Mandato = Console.ReadLine();

                if (Mandato == "1")
                {
                    MOficiales.Opciones(0);
                }
                if (Mandato == "2")
                {
                    MOficiales.Opciones(1);
                }
                if(Mandato != "1" && Mandato != "2")
                {
                    Console.WriteLine("Seleccione una opcion valida\n");
                }
            }
            while (1 == 1);

        }
    }
}
