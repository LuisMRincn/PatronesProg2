using System;
using System.Collections.Generic;
using System.Text;

namespace PatronComand
{
    class MandatosOfficiales
    {
        private IEjecutar[] ejecutar = new IEjecutar[2];

        public MandatosOfficiales(Escavadora escav)
        {
            ejecutar[0] = new ComandoOn(escav);
            ejecutar[1] = new ComandoOf(escav);

        }

        public void Opciones(int opc)
        {
            ejecutar[opc].Ejecutar();
        }
    }
}
