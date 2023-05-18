using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil, Moto };
        private string patente;
        private DateTime horaEgreso;
        private DateTime horaIngreso;

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        public abstract string Descripcion {  get; }
        public abstract double CostoEstadia { get; }

        public DateTime HoraEgreso
        {
            get { return this.horaEgreso; }
            set {  this.horaEgreso = value; }
        }

        public DateTime HoraIngreso
        {
            get { return this.horaIngreso; }
        }

        public string Patente
        {
            get { return this.Patente; }
            set 
            {
                if (this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        private bool ValidarPatente(string patente)
        {
            if (patente.Length > 6 && patente.Length < 7)
            {
                return true;
            }
            return false;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Hora de ingreso: {this.HoraIngreso}");

            return sb.ToString();
        }

        protected virtual double CargoDeEstacionamiento()
        {
            return (this.horaIngreso - this.horaEgreso).TotalHours;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}