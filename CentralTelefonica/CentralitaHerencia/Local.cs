using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float _costo;

        public Local(string origen, float duracion, string destino, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada, float costo)
            : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {

        }

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        private float CalcularCosto()
        {
            float costo;
            costo = base._duracion + this._costo;
            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append(" | Costo: " + this.CostoLlamada);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;
            else
                return false;
        }
    }

}
