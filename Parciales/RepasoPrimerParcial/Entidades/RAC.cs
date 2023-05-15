using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RAC : Empleados
    {
        public enum EGrupo { CALL_IN, CALL_OUT, RRSS };

        private EGrupo grupo;
        private static double valorHora;

        public EGrupo Grupo
        {
            get { return this.grupo; }
        }

        public static double ValorHora
        {
            get { return RAC.valorHora; }
            set 
            {
                if (value > 0)
                {
                    RAC.valorHora = value;
                } 
            }
        }

        static RAC() 
        {
            RAC.valorHora = 875.90f;
        }

        public RAC(string legajo, string nombre, TimeSpan horaEgrego):base(legajo, nombre, horaEgrego) { }
        public RAC(string legajo, string nombre, TimeSpan horaEgrego, EGrupo grupo) : this(legajo, nombre, horaEgrego)
        {
            this.grupo = EGrupo.CALL_IN;
        }

        public override string EmitirFactura()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Factura de: {base.Nombre}");
            sb.AppendLine($"Importe a facturar: {this.Factura()}");

            return sb.ToString();
        }

        private double CalcularBono()
        {
            if (grupo is EGrupo.CALL_IN)
            {
                return 0;
            }
            else if (grupo is EGrupo.CALL_OUT)
            {
                return 0.1;
            }
            else
            {
                return 0.2;
            }
        }

        protected override double Factura()
        {
            return (base.horaIngreso - base.horaEgreso).TotalHours * valorHora * (1 + CalcularBono());
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {grupo} - {legajo} - {nombre}";
        }
    }
}
