using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeShallow
{
  
    public class SerVivo: ICloneable
    {
        public string tipo { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
