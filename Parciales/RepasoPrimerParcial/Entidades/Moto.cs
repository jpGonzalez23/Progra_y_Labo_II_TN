using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport };
        private static double valorHora;
        private ETipo tipo;

        static Moto()
        {
            Moto.valorHora = 120;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo) : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        public static double ValorHora 
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }

        public override double CostoEstadia
        {
            get
            {
                return base.CargoDeEstacionamiento() * Moto.valorHora;
            }
        }

        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine("*****MOTO*****");
            mensaje.AppendLine(base.MostrarDatos());
            mensaje.AppendLine($"Tipo: {this.Descripcion}");

            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
