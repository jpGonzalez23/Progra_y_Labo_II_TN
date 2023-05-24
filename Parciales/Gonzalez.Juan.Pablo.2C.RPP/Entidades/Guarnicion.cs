using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guarnicion : Comida
    {
        public enum ETipo
        {
            PAPAS_FRITAS = 100,
            ENSALADA_RUSA = 750,
            ENSALADA_MIXTA = 500
        };

        private ETipo tipo;

        public Guarnicion() : this(ETipo.PAPAS_FRITAS) { }
        public Guarnicion(ETipo tipo) : base(tipo.ToString())
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Guarnicion g, EIngredientes ingredientes)
        {
            if (ingredientes is EIngredientes.ADHERESO || ingredientes is EIngredientes.ADHERESO || ingredientes is EIngredientes.QUESO)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Guarnicion g, EIngredientes ingredientes)
        {
            return !(g == ingredientes);
        }

        public override string ToString()
        {
            return $"Guarnicion de tipo - {this.tipo}";
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Guarnicion: {this.tipo}");

            return sb.ToString();
        }

        protected override string AgregarIngredientes(EIngredientes ingredientes)
        {
            if ((Comida) this != ingredientes && this == ingredientes) 
            {
                base.ingredientes.Add(ingredientes);
                return "";
            }
            return "";
        }

        protected override double CalcularCosto()
        {
            double costo = (int)this.tipo;

            base.ingredientes.ForEach(i => costo += (costo * (int)i / 100));

            return costo;
        }

        public static explicit operator Guarnicion(ETipo tipo)
        {
            return new Guarnicion(tipo);
        }
    }
}
