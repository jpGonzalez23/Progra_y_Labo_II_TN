using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Competencia
{
    public class VehiculoDeCarrera
    {
        private short cantCombustible;
        private short numero;
        private short vueltasRestantes;
        private string escuderia;
        private bool enCompetencia;

        /// <summary>
        /// Constructor de instancia de la clase VehiculoDeCarrera
        /// </summary>
        /// <param name="numero">Parametro a ingresar, numero del vehiculo</param>
        /// <param name="escuderia">Parametro a ingresar, nombre de la escuderia del vehiculo</param>
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        /// <summary>
        /// Propiedad del atributo cantCombuisteble, set y get
        /// </summary>
        public short CantCombustible { get => this.cantCombustible; set => this.cantCombustible = value; }

        /// <summary>
        /// Propiedad del atributo numero, set y get
        /// </summary>
        public short Numero { get => this.numero; set => this.numero = value; }

        /// <summary>
        /// Propiedad del atributo vueltasRestantes, set y get
        /// </summary>
        public short VueltasRestantes { get => this.vueltasRestantes; set => this.vueltasRestantes = value; }

        /// <summary>
        /// Propiedad del atributo Escuderia, set y get
        /// </summary>
        public string Escuderia { get => this.escuderia; set => this.escuderia = value; }

        /// <summary>
        /// Propiedad del atributo enCompetencia, set y get 
        /// </summary>
        public bool EnCompetencia { get => this.enCompetencia; set => this.enCompetencia = value; }


        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="v1">Parametro a recibir</param>
        /// <param name="v2">Parametro a recibir</param>
        /// <returns>Retorna true si la escuderia y numero son iguales</returns>
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.Escuderia == v2.Escuderia) && (v1.Numero == v2.Numero);
        }

        /// <summary>
        /// Sobrecarga del operador != 
        /// </summary>
        /// <param name="v1">Parametro a recibir</param>
        /// <param name="v2">Parametro a recibir</param>
        /// <returns>Retorna true si la escuderia y numero son distintos</returns>
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Metodo para mostrar los datos del vehiculos
        /// </summary>
        /// <returns>Retorna una cadena de caracteres</returns>
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero del vehiculo: {this.Numero}");
            sb.AppendLine($"Escuderia del vehiculo: {this.Escuderia}");
            sb.AppendLine($"En competencia: {this.EnCompetencia}");
            sb.AppendLine($"Cantidad de combustible: {this.CantCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");

            return sb.ToString();
        }
    }
}
