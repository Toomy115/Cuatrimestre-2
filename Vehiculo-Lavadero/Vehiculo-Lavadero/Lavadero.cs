using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo_Lavadero
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;

        private Lavadero()
        {
            _vehiculos = new List<Vehiculo>();
        }

        static Lavadero()
        {
            Random random = new Random();
            _precioAuto = random.Next(150, 565);
            _precioCamion = random.Next(150, 565);
            _precioMoto = random.Next(150, 565);
        }

        public Lavadero(string razon)
            : this()
        {
            this._razonSocial = razon;
        }

        public List<Vehiculo> Vehiculos { get { return this._vehiculos; } }

        public string RazonSocial { get { return this._razonSocial; } }

        public string InformeLavadero 
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" Razon Social: " + this._razonSocial);
                sb.AppendLine(" Precios Vigentes: ");
                sb.AppendLine(" Auto: " + _precioAuto);
                sb.AppendLine(" Moto: " + _precioMoto);
                sb.AppendLine(" Camion: " + _precioCamion);
                sb.AppendLine("Vehiculos: ");
                foreach(Vehiculo vec in this.Vehiculos)
                {
                    sb.AppendLine(vec.ToString());
                }
                
                return sb.ToString();
            }
        }

        public double MostrarTotalFacturado()
        {
            double retorno = 0;

            retorno += MostrarTotalFacturado(EVehiculos.Auto);
            retorno += MostrarTotalFacturado(EVehiculos.Camion);
            retorno += MostrarTotalFacturado(EVehiculos.Moto);

            return retorno;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double retornoAuto=0;
            double retornoMoto = 0;
            double retornoCamion = 0;
            double total = 0;
            foreach (Vehiculo vec in this.Vehiculos)
            {
                if (vehiculo == EVehiculos.Auto)
                {
                    retornoAuto += _precioAuto;
                }
                else
                {
                    if (vehiculo == EVehiculos.Camion)
                    {
                        retornoCamion += _precioCamion;
                    }
                    else
                    {
                        retornoMoto += _precioMoto;
                    }
                }
            } 
            switch (vehiculo)
            {
                case EVehiculos.Auto:
                    total = retornoAuto;
                    break;
                    
                case EVehiculos.Camion:
                    total = retornoCamion;
                    break;

                case EVehiculos.Moto:
                    total = retornoMoto;
                    break;
            }
            return total;       
        }

        public static Lavadero operator - (Lavadero lavadero, Vehiculo vehiculo)
        {
            //llama al igual igual para ver si esta
            if (lavadero == vehiculo)
            {
                lavadero.Vehiculos.RemoveAt(vehiculo == lavadero);
            }
            return lavadero;
        }
        
        public static Lavadero operator + (Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
            {
                lavadero.AgregarAuto(vehiculo);
            }
            return lavadero;
        }

        private void AgregarAuto (Vehiculo vehiculo)
        {
            this.Vehiculos.Add(vehiculo);
        }

        public static bool operator == (Lavadero lavadero, Vehiculo vehiculo)
        {
            foreach(Vehiculo vec in lavadero.Vehiculos)
            {
                if (vec == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static int operator == (Vehiculo vehiculo, Lavadero lavadero)
        {
            //recorre la lista retorna -1 si no encuentra el vehiculo, o la posicion 
            int retorno = -1;
            int cont = 0;
            foreach (Vehiculo vec in lavadero.Vehiculos)
            {                
                if (vec == vehiculo)
                {
                   retorno = cont ;
                }
                cont++;
            }
            return retorno;
        }

        public static int operator != (Vehiculo vehiculo, Lavadero lavadero)
        {
            return -1;
        }

        public static int OrdenarVehiculosPorPatente (Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            int retorno=-1;
            if (vehiculo1.Patente == vehiculo2.Patente)            
                retorno = 0;
            if (String.Compare(vehiculo1.Patente, vehiculo2.Patente) > 0)
                retorno = 1;
            return retorno;
        }

        public int OrdenarVehiculosPorMarca (Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            int retorno = -1;
            if (vehiculo1.Marca == vehiculo2.Marca)
                retorno = 0;
            if (String.Compare(vehiculo1.Marca.ToString(), vehiculo2.Marca.ToString()) > 0)
                retorno = 1;
            return retorno;
        }

    }
}
