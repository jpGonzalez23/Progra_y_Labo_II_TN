using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades.Models
{
    //15.Ahorcado, será genérica, solo podrá recibir tipos que implementen
    //  la interfaz Ilector y posean un constructor publico sin parámetros:
    //  a.En su constructor publico sin parámetros realizar:
    //      i.Instanciar el atributo entidad.
    //      ii.Inicializar:
    //          1.	estaAdivinada en false.
    //          2.	cantidadIntentosPorPalabra y cantidadAciertos en 0 (cero).
    //          3.	palabraSecreta en empty.
    //16.La propiedad Activar:
    //  a.El GET retornara True, si la tares no es nula y estado de la tarea es Running o WaitingToRun o WaitingForActivation.
    //  b.En el SET, si el valor recibido es TRUE y la tarea es nula o su estado no es Running o no es WaitingToRun o no es WaitingForActivation, se instanciará un nuevo CancelationTokenSource y se llamará a IniciarJuego. De lo contrario se llamará al método Cancel de cancellation.
    //17.El método IniciarJuego será privado y:
    //  a.Ejecutara en un hilo secundario la acción de que:
    //      i.Mientras no se requiera cancelación de la tarea invocara al mensaje
    //      NotificarNuevaPalabra y luego NotificarSegundosRestantes.Para este último enviar 30 segundos.
    //18.El método NotificarNuevaPalabra, verificara si el evento OnPalabra posee suscriptores
    //  y en caso exitoso realizara:
    //  a.Cambiar el estado del atributo estaAdivinada a False.
    //  b.Guardara en palabraSecreta el valor obtenido desde la entidad.
    //  c.cantidadDeIntentosPorPalabra será igual al doble de la longitud de la palabra secreta.
    //  d.Notificara la palabra secreta.
    //19.El método NotificarSegundosRestantes si posee un suscriptor notificara los segundos
    //restantes mientras que (Utilizar Thread.Sleep para dormir el hilo 1 segundos antes de ir decrementando):
    //  a.segundosRestantes sea mayor o igual a cero.
    //  b.El hilo secundario no requiera cancelación.
    //  c.La palabra no haya sido adivinada.
    //  d.La cantidad de intentos sea mayor que 0 (cero).
    //20.El método AsertarPalabra comparara la palabra secreta con la recibida por parámetro (usar ToLower para comparar).  Si son iguales cambiara el estado de estaAdivinada a True e incrementara el valor de cantidadDeAciertos en 1 (uno). De lo contrario restara cantidadDeIntentosPorPalabra.

    /// <summary>
    /// Declaracion del delegado
    /// </summary>
    /// <param name="palabra">Recibe una palabra</param>
    public delegate void DelegadoNuevaPalabra(string palabra);
    /// <summary>
    /// Declaracion del delegado
    /// </summary>
    /// <param name="segundos">Recibe los segundos</param>
    public delegate void DelegadoTemporizador(int segundos);

    public class Ahorcado<T> where T : ILector, new()
    {

        public event DelegadoNuevaPalabra OnPalabra;
        public event DelegadoTemporizador OnTemporizador;

        // Declaracion de atributos
        private CancellationTokenSource cancellation;
        private int cantidadDeAciertos;
        private int cantidadIntentosPorPalabra;
        private T entidades;
        private bool estaAdivinada;
        private string palabraSecreta;
        private Task tarea;

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Ahorcado()
        {
            this.entidades = new T();
            this.estaAdivinada = false;
            this.cantidadIntentosPorPalabra = 0;
            this.cantidadDeAciertos = 0;
            this.palabraSecreta = string.Empty;
        }

        /// <summary>
        /// Propiedad para el atributo tarea
        /// </summary>
        public bool Activar
        {
            get
            {
                return this.tarea != null && (this.tarea.Status == TaskStatus.Running 
                                          || this.tarea.Status == TaskStatus.WaitingToRun 
                                          || this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.Activar)
                {
                    this.cancellation = new CancellationTokenSource();
                    this.IniciarJuego();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }

        /// <summary>
        /// Propiedad de lectura para el atriburo de cantidadDeAciertos
        /// </summary>
        public int CantidadDeAciertos
        {
            get { return this.cantidadDeAciertos; }
        }

        /// <summary>
        /// Propiedad de lectura para el atributo de cantidadIntentosPorPalabra
        /// </summary>
        public int CantidadIntentosPorPalabra
        {
            get { return this.cantidadIntentosPorPalabra; }
        }

        /// <summary>
        /// Metodo para iniciar el juego
        /// </summary>
        private void IniciarJuego()
        {
            this.tarea = Task.Run(() =>
            {
                while (!this.cancellation.IsCancellationRequested)
                {
                    this.NotificarNuevaPalabra();
                    this.NotificarSegundosRestantes(30);
                }
            });

            
        }

        /// <summary>
        /// Metodo para notificar la nueva palabra
        /// </summary>
        private void NotificarNuevaPalabra()
        {
            if (OnPalabra is not null)
            {
                this.estaAdivinada = false;
                this.palabraSecreta = this.entidades.ObtenerNuevaPalabra();
                this.cantidadIntentosPorPalabra = 2 * this.palabraSecreta.Length;

                this.OnPalabra(this.palabraSecreta);
            }
        }

        /// <summary>
        /// Metodo para notificar los segundos restantes
        /// </summary>
        /// <param name="segundosRestantes">recibe los segundo a descontar</param>
        private void NotificarSegundosRestantes(int segundosRestantes)
        {
            if (this.OnTemporizador is not null)
            {
                while (segundosRestantes >= -1 && !this.cancellation.IsCancellationRequested 
                                               && !this.estaAdivinada 
                                               && this.cantidadIntentosPorPalabra > -1)
                {
                    Thread.Sleep(1000);
                    segundosRestantes--;
                    this.OnTemporizador(segundosRestantes);
                }
            }
        }

        /// <summary>
        /// Metodo para asertar palabra
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public bool AsertarPalabra(string palabra)
        {
            if (!string.IsNullOrEmpty(this.palabraSecreta))
            {
                if (this.palabraSecreta.ToLower() == palabra.ToLower())
                {
                    this.estaAdivinada = true;
                    this.cantidadDeAciertos++;
                }
                else
                {
                    this.cantidadIntentosPorPalabra--;
                }
            }
            return this.estaAdivinada;
        }
    }
}
