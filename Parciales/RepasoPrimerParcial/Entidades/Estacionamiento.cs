using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private string nombre;
        private List<Vehiculo> listVehiculos;
        private static Estacionamiento estacionamiento;

        public Estacionamiento(string nombre, int capacidad)
        {
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
            this.listVehiculos = new List<Vehiculo>();
        }

        public List<Vehiculo> ListadoVehiculo
        {
            get
            {
                return this.listVehiculos;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Retiro de Estacionamiento: {this.nombre}");
            mensaje.AppendLine(vehiculo.ToString());
            mensaje.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            mensaje.AppendLine($"El cargo por estacionamiento es: {vehiculo.CostoEstadia.ToString("00.0")}");

            return mensaje.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (Estacionamiento.estacionamiento.listVehiculos.Count > 0)
            {
                foreach (Vehiculo v in estacionamiento.listVehiculos)
                {
                    if (v == vehiculo)
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returnAux = false;
            if (estacionamiento.listVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                Estacionamiento.estacionamiento.listVehiculos.Add(vehiculo);
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo) 
        {
            bool returnAux = false;
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                Estacionamiento.estacionamiento.listVehiculos.Remove(vehiculo);
                returnAux = true;
            }
            return returnAux;
        }
    }
}
