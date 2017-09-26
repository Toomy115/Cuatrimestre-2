using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Lavadero
{
    public class Camion : Vehiculo
    {       
        protected float _tara;             

        public Camion(Vehiculo v, float tara)
            :this(v.Patente,v.Marca,tara)
        {
                     
        }

        public Camion(string patente, EMarcas marca, float tara)
            : base(patente, marca, 4)
        {
            this._tara = tara;  
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(" Tara: " + this._tara);
            return sb.ToString();
        }
    }
}
