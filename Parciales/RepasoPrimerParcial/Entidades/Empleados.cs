using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empleados
    {
        protected string nombre;
        protected string legajo;
        protected TimeSpan horaEgreso;
        protected TimeSpan horaIngreso;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Legajo
        {
            get { return this.legajo; }
        }

        public TimeSpan HoraEgreso
        {
            get { return this.horaEgreso; }
            set 
            {
                ValidarHoraEgreso(value);
            }
        }

        public TimeSpan HoraIngreso
        {
            get { return this.horaIngreso; }
        }

        protected Empleados(string legajo, string nombre, TimeSpan horaIngreso)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.horaIngreso = horaIngreso;
        }

        protected virtual double Factura()
        {
            return (this.horaEgreso - this.horaIngreso).TotalHours;
        }

        public abstract string EmitirFactura();

        private TimeSpan ValidarHoraEgreso(TimeSpan horaEgreso)
        {
            if (this.horaIngreso > horaEgreso)
            {
                return this.horaEgreso;
            }
            else
            {
                return DateTime.Now.TimeOfDay;
            }
        }

        public static bool operator ==(Empleados e1, Empleados e2)
        {
            return e1.legajo == e2.legajo;
        }

        public static bool operator !=(Empleados e1, Empleados e2)
        {
            return !(e1 == e2);
        }
    }
}
