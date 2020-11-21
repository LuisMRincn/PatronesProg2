using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComand
{
    class ComandoOn: IEjecutar
    {
        Escavadora Escavadora;

        public ComandoOn(Escavadora escv)
        {
            Escavadora = escv;
        }
        public void Ejecutar()
        {
            Escavadora.Encender();
        }
    }

    class ComandoOf: IEjecutar
    {
        Escavadora Escavadora;

        public ComandoOf(Escavadora escv)
        {
            Escavadora = escv;
        }
        public void Ejecutar()
        {
            Escavadora.Apagar();
        }

    }
}
