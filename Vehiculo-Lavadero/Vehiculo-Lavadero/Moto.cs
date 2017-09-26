using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Lavadero
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(Vehiculo v, float cilindrada)
            :this(v.Patente,v.Marca,cilindrada)
        {
            
        }

        public Moto(string patente, EMarcas marca, float cilindrada)
            : base(patente, marca, 2)
        {
            this._cilindrada = cilindrada;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(" Cilindrada: " + this._cilindrada);
            return sb.ToString();
        }
    }
}
