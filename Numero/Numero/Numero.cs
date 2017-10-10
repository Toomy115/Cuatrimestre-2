using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNumero
{
    public class Numero
    {
        protected int _numero;

        public int ObtenerNumero { get { return _numero; } }

        public Numero(int numero)
        {
            _numero = numero;
        }

        public static int operator +(Numero numero1, Numero numero2)
        {
            return numero1.ObtenerNumero + numero2.ObtenerNumero;
        }

        public static int operator -(Numero numero1, Numero numero2)
        {
            return numero1.ObtenerNumero - numero2.ObtenerNumero;
        }
        public static int operator * (Numero numero1, Numero numero2)
        {
            return numero1.ObtenerNumero * numero2.ObtenerNumero;
        }
        public static double operator / (Numero numero1, Numero numero2)
        {
            double retorno= 0;
            try
            {
                retorno =  Convert.ToDouble(numero1.ObtenerNumero / numero2.ObtenerNumero);
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Intento dividir por cero");
                Console.ReadLine();
            }
            return retorno;
           
        }

        

    }
}
