using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supervisor : Empleados
    {
        private static double valorHora;

        public static double ValorHora
        {
            get { return Supervisor.ValorHora; }
            set
            {
                if (value > 0)
                {
                    Supervisor.valorHora = value;
                }
            }
        }

        static Supervisor()
        {
            Supervisor.valorHora = 1025.50F;
        }

        private Supervisor(string legajo) : base(legajo, "n/a", new TimeSpan(09,00,00)) { }

        public Supervisor(string legajo, string nombre, TimeSpan horaEgreso) : this(legajo) { }

        protected override double Factura()
        {
            return (base.horaIngreso - base.horaEgreso).TotalHours * Supervisor.valorHora;
        }

        public override string EmitirFactura()
        {
            return $"Factura de: {base.Nombre}\nImporte a facturar: {this.Factura() }";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {legajo} - {nombre}";
        }
    }
}
