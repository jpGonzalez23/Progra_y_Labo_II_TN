using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Vehiculo;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> vehiculos;
        private string nombre;

        private Estacionamiento(string nombre, int capacidad) 
        {
            this.capacidadEstacionamiento = capacidad;
            this.nombre = nombre;
            this.vehiculos = new List<Vehiculo>();
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento == null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.nombre = nombre;
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }

            return Estacionamiento.estacionamiento;
        }

        public List<Vehiculo> ListadoVehiculo
        {
            get
            {
                return this.vehiculos;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del estacionamiento: {this.Nombre}");
            sb.AppendLine($"Datos del vehiculo: {vehiculo.Patente} - {vehiculo.Descripcion}");
            sb.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            sb.AppendLine($"Cargo del estacionamiento: {vehiculo.CostoEstadia}");

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            if (e.vehiculos.Count > 0)
            {
                foreach (Vehiculo vehiculo in e.vehiculos)
                {
                    if (vehiculo == v)
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static bool operator +(Estacionamiento e, Vehiculo v)
        {
            if (e == v && e.ListadoVehiculo.Count < e.capacidadEstacionamiento)
            {
                e.vehiculos.Add(v);
                return true;
            }

            return false;
        }

        public static bool operator -(Estacionamiento e, Vehiculo v)
        {
            if (e.vehiculos.Contains(v))
            {
                v.HoraEgreso = DateTime.Now;
                return true;
            }
            return false;
        }
    }
}
