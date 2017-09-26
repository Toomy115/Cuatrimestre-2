using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public Provincial(string origen, Franja unaFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = unaFranja;

        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)0.99 * base.Duracion;
                    break;
                case Franja.Franja_2:
                    retorno = (float)1.25 * base.Duracion;
                    break;
                case Franja.Franja_3:
                    retorno = (float)0.66 * base.Duracion;
                    break;
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine(" | Franja: " + Convert.ToString(this._franjaHoraria));
            sb.Append(" | Costo llamada: " + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            else
                return false;
        }
    }
}
