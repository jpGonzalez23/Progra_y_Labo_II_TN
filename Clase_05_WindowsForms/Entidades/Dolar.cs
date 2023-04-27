namespace Entidades
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region Constructores
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }
        #endregion

        #region Metodos

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static void SetCotizacion(double paramCotizacio)
        {
            cotizRespectoDolar = paramCotizacio;
        }

        public double GetCantidad()
        {
            return cantidad;
        }
        #endregion

        #region Conversiones

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.cantidad * Peso.GetCotizacion());
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad * Euro.GetCotizacion());
        }
        #endregion

        #region Operaciones

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == ((Dolar)p).cantidad;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == ((Dolar)e).cantidad;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }
        #endregion
    }
}