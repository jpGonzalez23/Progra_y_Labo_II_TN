using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(Object sender, short movimiento);
    public class Juego
    {
        public event InformacionDeAvance InformarAvance;

        private static short velocidad;
        private short ubicacion;
        private object controlVisual;

        /// <summary>
        /// 
        /// </summary>
        static Juego()
        {
            Juego.velocidad = 8;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ubicacion"></param>
        /// <param name="objetoVisual"></param>
        public Juego(short ubicacion, object objetoVisual)
        {
            this.ubicacion = ubicacion;
            this.controlVisual = objetoVisual;
        }

        /// <summary>
        /// 
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual
        {
            get
            {
                return this.controlVisual;
            }
            set
            {
                this.controlVisual = value;
            }
        }

        public short Ubicacion { get => this.ubicacion; set => this.ubicacion = value; }
        public static short Velocidad { get => Juego.velocidad; set => Juego.velocidad = value; }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public short Avanzar()
        {
            this.ubicacion += velocidad;
            return this.ubicacion;
        }

        /// <summary>
        /// Simular la animación del Carrusel
        /// </summary>
        public void IniciarCarrusel()
        {
            do
            {
                this.ubicacion += Juego.velocidad;

                InformarAvance.Invoke(this, this.ubicacion);

                System.Threading.Thread.Sleep(60 + Juego.velocidad);
            } while (true);
        }
    }
}
