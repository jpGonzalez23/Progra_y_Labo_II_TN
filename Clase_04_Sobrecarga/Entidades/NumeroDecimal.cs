using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero) 
        {
            this.numero = numero;
        }

        public double Numero
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

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal numeroDeci)
        {
            return numeroDeci.Numero;
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDeci)
        {
            NumeroBinario aux = Conversor.DecimalBinario(numeroDeci.numero);
            return aux;
        }

        public static double operator +(NumeroDecimal numDeci, NumeroBinario numBin)
        {
            double aux = (double)((NumeroDecimal)numBin);
            double suma = aux + (double)numDeci;

            return suma;
        }

        public static double operator -(NumeroDecimal numDeci, NumeroBinario numBin)
        {
            double aux = (double)((NumeroDecimal)numBin);
            double suma = aux - (double)numDeci;

            return suma;
        }

        public static bool operator ==(NumeroDecimal numDeci, NumeroBinario numBin)
        {
            return (numDeci.numero == ((NumeroDecimal)numBin).numero);
        }

        public static bool operator !=(NumeroDecimal numDeci, NumeroBinario numBin)
        {
            return !(numDeci == numBin);
        }
    }
}
