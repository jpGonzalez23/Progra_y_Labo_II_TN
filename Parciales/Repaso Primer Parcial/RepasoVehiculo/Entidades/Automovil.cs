using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil()
        {
            Automovil.valorHora = 120;
        }

        public Automovil(string patente, DateTime horaIngreso, string marca) 
            : base(patente, horaIngreso)
        {
            this.marca = marca;
        }

        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Automovil.valorHora = value;
                }
            }
        }

        public override double CostoEstadia
        {
            get { return this.CargoDeEstacionamiento(); }
        }

        public override string Descripcion
        {
            get { return this.marca; }
        }

        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;   
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("***** AUTOMOVIL *****");
            sb.AppendLine(base.MostrarDatos());
            sb.Append($"Marca: {this.Descripcion}");
            sb.AppendLine($"Cargo de estadia: {this.CargoDeEstacionamiento}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
