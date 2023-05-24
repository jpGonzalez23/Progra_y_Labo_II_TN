using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private List<Comida> menu;

        private Cliente(int dni)
        {
            this.dni = dni;
            this.menu = new List<Comida>();
        }

        public static implicit operator Cliente(int dni)
        {
            return new Cliente(dni);
        }

        public static Cliente GetCliente(int dni)
        {
            
        }

        private double TotalAPagar
        {
            get 
            {
                StringBuilder sb = new StringBuilder();

                return sb.ToString();
            }
        }

        public Comida BuscarComida(Comida comida)
        {

        }

        public static Cliente operator +(Cliente cliente)
        {

        }


        public static string ImprimirTicket(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Dni del cliente: {cliente.dni}");
            sb.AppendLine("");
            sb.AppendLine($"Total a pagar: {cliente.TotalAPagar}");

            return sb.ToString();
        }

        public static bool operator ==(Cliente cliente, Comida comida)
        {

        }

        public static bool operator !=(Cliente cliente, Comida comida)
        {
            return !(cliente == comida);
        }
    }
}
