namespace Entidades
{
    public class Alumno
    {
        private byte notaUno;
        private byte notaDos;
        private float notaFinal;

        public string apellido;
        public string nombre;
        public int legajo;

        // Creacion de instancia

        /// <summary>
        /// Instancia para el ingreso del datos del alumno
        /// </summary>
        /// <param name="apellido">Ingreso del Nombre</param>
        /// <param name="nombre">Ingreso del apellido</param>
        /// <param name="legajo">Ingreso del legajo</param>
        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this.notaFinal = -1;
        }

        // Creacion de Metodos

        /// <summary>
        /// Metodo para la notaFinal
        /// </summary>
        public void CalcularFinal()
        {
            if (notaUno >= 4 && notaDos >= 4)
            {
                Random nota = new Random();
                notaFinal = nota.Next(4, 11);
            }
            else
            {
                notaFinal = -1;
            }
        }

        /// <summary>
        /// Metodo para ingresar la notaUno y notaDos
        /// </summary>
        /// <param name="notaUno">Ingreso de notaUno</param>
        /// <param name="notaDos">Ingreso de notaDos</param>
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.notaUno = notaUno;
            this.notaDos = notaDos;
        }

        /// <summary>
        /// Metedo para mostrar 
        /// </summary>
        /// <returns>Retorna un cadena de string</returns>
        public string Mostrar()
        {
            return $"Nombre: {nombre}\nApellido: {apellido}\nLegajo: {legajo}\nNota uno: {notaUno}\nNota dos: {notaDos}\nNota final: {notaFinal}\n";
        }
    }
}