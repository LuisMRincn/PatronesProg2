using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private int Dolar = 10;
        private int resultado;

        
        private Singleton() {
            resultado = Dolar * 58;
        }

        private static Singleton Ejemplo;

        public static Singleton Validacion()
        {
            if (Ejemplo == null)
            {

                Ejemplo = new Singleton();

            }
            return Ejemplo;
        }
        public override string ToString()
        {
            return resultado.ToString();
        }

        
    }
}
