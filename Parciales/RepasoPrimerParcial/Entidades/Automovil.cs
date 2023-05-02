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

        public Automovil(string marca, string patente, DateTime horaIngreso) : base(patente, horaIngreso)
        {
            this.marca = marca;
        }

        public static double ValorHora
        {
            set
            {
                if(value > 0)
                {
                    Automovil.valorHora = 0;
                }
            }
        }

        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }

        public override string Descripcion
        {
            get 
            { 
                return this.marca;  
            }
        }

        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;
        }

        protected override string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine("*****AUTOMOVIL*****");
            mensaje.AppendLine(base.MostrarDatos());
            mensaje.AppendLine($"Marca: {this.Descripcion}");


            return mensaje.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
