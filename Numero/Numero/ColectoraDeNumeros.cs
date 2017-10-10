using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNumero
{
    public class ColectoraDeNumeros
    {
        private List<Numero> numeros;

        private ColectoraDeNumeros()
        {
            this.numeros = new List<Numero>();
        }

        public  ColectoraDeNumeros(ETipoNumero tipo)
        {
            this.Numeros = tipo;
        }

        public ETipoNumero Numeros { get; set; }
        public int ObtenerSuma
        {
            get
            {
                int suma= Convert.ToInt32(this.numeros[0]);
                List<Numero> aux= new List<Numero> ();
                aux= this.numeros;
                aux.RemoveAt(0);

                foreach (Numero i in aux)
                {
                    suma += i.ObtenerNumero;
                    
                }

                return suma;
            }
        }

        public int ObtenerResta 
        {
            get
            {
                int resta = Convert.ToInt32(this.numeros[0]);
                List<Numero> aux = new List<Numero>();
                aux = this.numeros;
                aux.RemoveAt(0);

                foreach (Numero i in aux)
                {
                    resta -= i.ObtenerNumero;

                }

                return resta;
                 
            }
            
        }
    
        public static ColectoraDeNumeros operator + (ColectoraDeNumeros colectora, Numero numero)
        {
            colectora.numeros.Add(numero);
            return colectora;

        }

        public static ColectoraDeNumeros operator - (ColectoraDeNumeros colectora, Numero numero)
        {
            colectora.numeros.Remove(numero);
            return colectora;
        }

        
        public static bool operator ==(ColectoraDeNumeros colectora, Numero numero)
        {
            bool retorno = false;

            foreach (Numero i in colectora.numeros)
            {
                if (i.ObtenerNumero == numero.ObtenerNumero)
                {
                    retorno = true;
                }
                
            }

            return retorno;
        }

        public static bool operator !=(ColectoraDeNumeros colectora, Numero numero)
        {
            return !(colectora == numero);
        }

        public override string ToString()
        {
            return "";
        }
    }

}
