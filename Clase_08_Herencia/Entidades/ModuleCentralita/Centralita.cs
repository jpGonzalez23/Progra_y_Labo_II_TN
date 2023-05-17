using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleCentralita
{
    public class Centralita
    {
        private List<Llamada> llamada;
        protected string razonSocial;

        public Centralita()
        {
            this.llamada = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get { return this.llamada; }
        }

        //public float GananciasPorLocal
        //{
        //    get 
        //    {
        //        return this.CalcularGanancia(Llamada.ETipoLlamada.Local);
        //    }
        //}

        //public float GananciasPorProvincia
        //{
        //    get 
        //    {
        //        return this.CalcularGanancia(Llamada.ETipoLlamada.Provincíal);
        //    }
        //}

        //public float GananciasTotal
        //{
        //    get 
        //    {
        //        return this.CalcularGanancia(Llamada.ETipoLlamada.Todas);
        //    }
        //}

        //public string Mostrar()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine($"Ganacia por local: {this.GananciasPorLocal}");
        //    sb.AppendLine($"Ganacia por provincia: {this.GananciasPorProvincia}");
        //    sb.AppendLine($"Ganacia total: {this.GananciasTotal}");

        //    return sb.ToString();
        //}

        //private float CalcularGanancia(Llamada.ETipoLlamada tipo)
        //{
        //    if (tipo == Llamada.ETipoLlamada.Local)
        //    {
        //        return ;
        //    }
        //    else if (tipo == Llamada.ETipoLlamada.Provincíal)
        //    {
        //        return ;
        //    }
        //    else
        //    {
        //        return ;
        //    }
        //}

        public void OrdenarLlamadas()
        {

        }
    }
}
