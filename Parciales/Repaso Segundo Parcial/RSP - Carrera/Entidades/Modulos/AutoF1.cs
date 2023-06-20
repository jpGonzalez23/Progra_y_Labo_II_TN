namespace Entidades.Modulos
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;

        /// <summary>
        /// Propiedad del atributo Velocidad
        /// </summary>
        public int Velocidad { get => velocidad; set => velocidad = value; }

        /// <summary>
        /// Propiedad del atributo Escuderia
        /// </summary>
        public string Escuderia { get => escuderia; set => escuderia = value; }

        /// <summary>
        /// Propiedad del atributo Posicion
        /// </summary>
        public int Posicion { get => posicion; set => posicion = value; }

        /// <summary>
        /// Propiedad del atributo puntoPartida
        /// </summary>
        public int UbicacionEnPista
        {
            get
            {
                return this.puntoPartida;
            }
            set
            {
                this.puntoPartida = value;
            }
        }

        /// <summary>
        /// Constructor sin parametro
        /// </summary>
        public AutoF1()
        {

        }

        /// <summary>
        /// sobrecarga del Constructor
        /// </summary>
        /// <param name="escuderia">Recibe el nombre de la escuderia</param>
        /// <param name="velocidad">Recibe la velocidad</param>
        /// <param name="puntoPartida">Recibe el punto de partida</param>
        public AutoF1(string escuderia, int velocidad, int puntoPartida) : this()
        {
            this.escuderia = escuderia;
            this.velocidad = velocidad;
            this.puntoPartida = puntoPartida;
        }

        /// <summary>
        /// Meotodo para acelerar a los autos
        /// </summary>
        public void Acelerar()
        {
            this.Velocidad += this.UbicacionEnPista;
        }

        /// <summary>
        /// Sobrecarga de ToString
        /// </summary>
        /// <returns>Retorna una cadena de caracteres</returns>
        public override string ToString()
        {
            return $"Escuderia: {Escuderia} - Posicion: {Posicion}";
        }
    }
}