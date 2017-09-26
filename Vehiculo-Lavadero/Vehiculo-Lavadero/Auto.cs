using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Lavadero
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;
        

        public Auto(int asientos, Vehiculo v):this(v.Patente,v.Marca,asientos)
        {
                        
        }

        public Auto(string patente, EMarcas marca, int cantAsientos)
            :base(patente,marca,4)
        {
            this._cantidadAsientos = cantAsientos;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(" Cantidad de Asientos: " + this._cantidadAsientos);
            return sb.ToString();
        }


    }
}
