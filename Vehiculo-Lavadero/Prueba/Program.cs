using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculo_Lavadero;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero miLavadero = new Lavadero("Tomas Shower");
            Vehiculo auto = new Vehiculo("IMO 379", EMarcas.Ford, 4);
            Vehiculo moto = new Vehiculo("GHR 472", EMarcas.Zanella, 2);
            Vehiculo camion = new Vehiculo("PAA 568", EMarcas.Iveco, 6);
            Auto auto1 = new Auto(5, auto);
            Auto auto2 = new Auto("ABC 123", EMarcas.Fiat, 4);
            Moto moto1 = new Moto(moto, 200);
            Moto moto2 = new Moto("UFR 623", EMarcas.Honda, 1505);
            Camion camion1 = new Camion(camion, 5000);
            Camion camion2 = new Camion("HPE 987", EMarcas.Scania, 10000);

            Console.WriteLine("Se agregan vehiculos al lavadero " + miLavadero.RazonSocial);
            miLavadero += auto1;
            miLavadero += auto2;
            miLavadero += moto1;
            miLavadero += moto2;
            miLavadero += camion1;
            miLavadero += camion2;
            Console.WriteLine("Informe del lavadero: \n" + miLavadero.InformeLavadero);
            Console.Read();
            Console.WriteLine("\nIngresos del lavadero: " + miLavadero.MostrarTotalFacturado());
            Console.Read();
            Console.WriteLine("\nSe ordenan los vehiculos por MARCA: \n");
            miLavadero.Vehiculos.Sort(miLavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine(miLavadero.InformeLavadero);
            Console.Read();
            Console.WriteLine("\nSe ordenan los vehiculos por PATENTE: \n");
            miLavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(miLavadero.InformeLavadero);
            Console.Read();
            Console.WriteLine("\nQuito una moto del lavadero.. \n");
            miLavadero -= moto1;
            Console.WriteLine(miLavadero.InformeLavadero);
            Console.Read();
            Console.WriteLine("\nQuito los camiones del lavadero.. \n");
            miLavadero -= camion1;
            miLavadero -= camion2;
            Console.WriteLine(miLavadero.InformeLavadero);
            Console.Read();
            Console.WriteLine("\nIngresos del lavadero actualizados: " + miLavadero.MostrarTotalFacturado());
            Console.Read();



        }
    }
}
