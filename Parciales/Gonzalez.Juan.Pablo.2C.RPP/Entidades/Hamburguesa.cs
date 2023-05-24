using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hamburguesa : Comida
    {
        private static double costoBase;
        private bool esDoble;

        static Hamburguesa()
        {
            Hamburguesa.costoBase = 1500;
        }

        public Hamburguesa(string nombre) : base(nombre) { }

        public Hamburguesa(string nombre, bool esDoble) : this(nombre)
        {
            this.esDoble = esDoble;
        }

        protected override string AgregarIngredientes(EIngredientes ingredientes)
        {
            if (this != ingredientes)
            {
                base.ingredientes.Add(ingredientes);
                return $"Se agrego {ingredientes} a su hamburguesa";
            }
            return $"No se puedo agregar {ingredientes} a su hamburguesa";
        }

        public override string ToString()
        {
            if (this.esDoble)
            {
                return "Hamburguesa - Doble";
            }
            else
            {
                return "Hamburguesa - Simple";
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine(this.ToString());

            return sb.ToString();
        }

        protected override double CalcularCosto()
        {
            double costo = 0;

            if (this.esDoble)
            {
                Hamburguesa.costoBase += 500;
            }

            base.ingredientes.ForEach(i => costo += (costo * (int)i / 100));

            return costo;
        }
    }
}
