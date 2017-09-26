using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Lavadero
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        public Vehiculo(string patente, EMarcas marca, byte cant)
        {
            this._patente = patente;
            this._marca = marca;
            this._cantRuedas = cant;
        }

        public string Patente { get { return this._patente; } }
        public EMarcas Marca { get { return this._marca; } }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Patente: " + this._patente + " Marca: " + this._marca + " Cantidad de Ruedas: " + this._cantRuedas);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1._patente == v2._patente && v1._marca == v2._marca)
                return true;
            else
                return false;            
        }

        public static bool operator != (Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

        
    }
}
