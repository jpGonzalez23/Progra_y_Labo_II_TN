using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        // Generamos el constructor para Boligrafo
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.tinta = tinta;
            this.color = color;
        }

        /// <summary>
        /// Metodo publico para obtener el color de boligrafo
        /// </summary>
        /// <returns>Retorna el color</returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Metodo publico para obtener la cantidad de tinta del Boligrafo
        /// </summary>
        /// <returns>retorna la cantidad de tinta</returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Metodo privado para gastar o recargar tinta
        /// </summary>
        /// <param name="tinta">Es la cantidad de tinta</param>
        private void SetTinta(short tinta)
        {
            this.tinta = (short)(this.tinta + tinta);

            if (this.tinta >= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
            else if (this.tinta <= 0)
            {
                this.tinta = 0;
            }
        }

        /// <summary>
        /// Diujara tantos astericos como tinta se quiera y pueda gastar, en caso de no poseer tinta asignara "No se puede Pintar ya que no se posee tinta"
        /// </summary>
        /// <param name="gasto">Es la cantidad de tinta a gastar</param>
        /// <param name="dibujo">variable por referencia donde se va almacenar el resultado del dibujo</param>
        /// <returns>True en caso de haber podido dibujar, de lo contrario False</returns>
        public bool Pintura(short gasto, out string dibujo)
        {
            string cadenaAux = "";

            if (this.tinta == 0)
            {
                dibujo = "No pudo pintar";
                return false;
            }

            dibujo = "Pude pintar";

            while (gasto > 0 && this.tinta > 0)
            {
                cadenaAux = cadenaAux + "*";
                this.SetTinta(-1);
                gasto--;
            }

            dibujo = cadenaAux;

            return true;
        }

        /// <summary>
        /// Setea la cantidad de tinta en su maximo posible
        /// </summary>
        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadTintaMaxima);
        }
    }
}
