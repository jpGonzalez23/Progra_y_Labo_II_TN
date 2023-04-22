using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private double cantidad;

        #region Constructores
        public Kelvin(double pCantidad)
        {
            this.cantidad = pCantidad;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Conversiones
        public static implicit operator Kelvin(double c)
        {
            return new Kelvin(c);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.cantidad * 9 / 5) - 459.67);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return (Celsius)((Fahrenheit)k);
        }
        #endregion

        #region Operaciones
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return (k1.cantidad == k2.cantidad);
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (k.cantidad == ((Kelvin)f).cantidad);
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return (k.cantidad == ((Kelvin)(c)).cantidad);
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        public static Kelvin operator +(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.cantidad + k2.cantidad);
        }

        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            return new Kelvin(k1.cantidad - k2.cantidad);
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.cantidad + ((Kelvin)f).cantidad);
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.cantidad - ((Kelvin)f).cantidad);
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.cantidad + ((Kelvin)c).cantidad);
        }
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.cantidad - ((Kelvin)c).cantidad);
        }

        #endregion
    }
}
