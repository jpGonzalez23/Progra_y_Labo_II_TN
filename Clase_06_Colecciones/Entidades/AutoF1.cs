using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private short numero;
        private short vueltasRestantes;
        private bool enCompetencia;
        private string escuderia;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Numero del corredor: {this.numero}");
            mensaje.AppendLine($"Nombre de la escuderia: {this.escuderia}");
            mensaje.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
            mensaje.AppendLine($"Esta en competencia: {this.EnCompetencia}");
            mensaje.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");

            return mensaje.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
     }
}
