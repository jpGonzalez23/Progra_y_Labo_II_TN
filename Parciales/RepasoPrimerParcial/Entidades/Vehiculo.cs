using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil, Moto };

        private string patente;
        private DateTime horaIngreso;
        private DateTime horaEgreso;

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.HoraEgreso = horaIngreso;
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }

            set
            {
                if(ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }
        }

        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }

            set
            {
                if(value > this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }

        public abstract string Descripcion 
        { 
            get; 
        }
        public abstract double CostoEstadia 
        { 
            get; 
        } 


        private bool ValidarPatente(string patente)
        {
            if(!string.IsNullOrEmpty(patente) && patente.Length >= 6 && patente.Length <= 8)
            {
                return true;
            }
            return false;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Patente: {this.Patente}");
            mensaje.AppendLine($"Hora de ingreso: {this.HoraIngreso}");

            return mensaje.ToString();
        }

        protected virtual double CargoDeEstacionamiento()
        {
            double horaAcumulada = 0;

            if(this.HoraEgreso > this.HoraIngreso)
            {
                horaAcumulada = (this.HoraEgreso - this.HoraIngreso).TotalHours;
            }

            return horaAcumulada;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }

}