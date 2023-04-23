using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;   
        }

        public string Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }

        public static implicit operator NumeroBinario(string numeroBin) 
        {
            return new NumeroBinario(numeroBin);
        }

        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;
        }

        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            NumeroDecimal aux = Conversor.BinarioDecimal(numeroBinario.numero);
            return aux;
        }

        public static string operator +(NumeroBinario numBin, NumeroDecimal numDeci)
        {
            return Conversor.DecimalBinario(numDeci + numBin);
        }

        public static string operator -(NumeroBinario numBin, NumeroDecimal numDeci)
        {
            StringBuilder sb = new StringBuilder();

            double aux = (double)((NumeroDecimal)numBin);
            double acumaldor = default(double);

            if(aux <=-(double)numDeci)
            {
                acumaldor = aux - (double)numDeci;
                sb.AppendLine("La resta es: " + acumaldor);
            }
            else
            {
                sb.AppendLine("No puede dar numero negativo");
            }

            return sb.ToString();
        }

        public static bool operator ==(NumeroBinario numBin, NumeroDecimal numDeci)
        {
            return (numBin.numero == ((NumeroBinario)numDeci).numero);
        }

        public static bool operator !=(NumeroBinario numBin, NumeroDecimal numDeci)
        {
            return !(numBin == numDeci);
        }
    }
}
