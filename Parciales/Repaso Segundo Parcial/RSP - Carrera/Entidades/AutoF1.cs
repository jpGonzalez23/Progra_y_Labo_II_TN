namespace Entidades
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;

        public int Velocidad { get => this.velocidad; set => this.velocidad = value; }
        public string Escuderia { get => this.escuderia; set => this.escuderia = value; }
        public int Posicion { get => this.posicion; set => this.posicion = value; }
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

        public AutoF1()
        {

        }

        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.escuderia = escuderia;
            this.velocidad = velocidad;
            this.puntoPartida = puntoPartida;
        }

        public void Acelerar()
        {
            this.Velocidad += this.UbicacionEnPista;
        }

        public override string ToString()
        {
            return $"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}";
        }
    }
}