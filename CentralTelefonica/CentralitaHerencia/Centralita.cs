using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada i in this._listaDeLlamadas)
            {
                if (i is Local)
                {
                    gananciaLocal += ((Local)i).CostoLlamada;
                }
                if (i is Provincial)
                {
                    gananciaProvincial += ((Provincial)i).CostoLlamada;
                }
            }
            switch (tipo)
            {

                case TipoLlamada.Local:
                    return gananciaLocal;

                case TipoLlamada.Provincial:
                    return gananciaProvincial;

                case TipoLlamada.Todas:
                    return gananciaLocal + gananciaProvincial;
            }

            return 1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social: " + this._razonSocial);
            sb.AppendLine("Ganancia Total: " + GananciaTotal);
            sb.AppendLine("Ganancia Por Llamados Locales: " + GananciaPorLocal);
            sb.AppendLine("Ganancia Por Llamados Provinciales: " + GananciaPorProvincial);
            foreach (Llamada i in this.Llamadas)
            {
                sb.AppendLine(i.ToString());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLLamada(Llamada uno)
        {
            this.Llamadas.Add(uno);
        }

        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada i in centralita.Llamadas)
            {
                if (i == llamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }

        public static Centralita operator +(Centralita centralita, Llamada llamada)
        {
            if (!(centralita == llamada))
            {               
                centralita.AgregarLLamada(llamada);
            }
            return centralita;
        }


        public float GananciaPorLocal { get { return this.CalcularGanancia(TipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancia(TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this._listaDeLlamadas; } }
    }

}