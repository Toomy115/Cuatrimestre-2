using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion { get { return this._duracion; } }
        public string NroDestino { get { return this._nroDestino; } }
        public string NroOrigen { get { return this._nroOrigen; } }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Origen: " + this._nroOrigen);
            sb.AppendLine(" | Destino: " + this._nroDestino);
            sb.AppendLine(" | Duracion: " + this._duracion);
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int retorno = 0;
            if (uno._duracion < dos._duracion)
            {
                retorno = 1;
            }
            if (uno._duracion > dos._duracion)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            bool retorno = false;
            if (uno._nroOrigen == dos._nroOrigen && uno._nroDestino == dos._nroDestino && uno.Equals(dos))
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }



    }
}
