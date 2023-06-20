using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modulos
{
    /// <summary>
    /// Declaracion del delegado InformacionDeAvance
    /// </summary>
    public delegate void InformacionDeAvance();
    /// <summary>
    /// Declaracion del delegado InformacionLlegada
    /// </summary>
    public delegate void InformacionLlegada();

    public class Carrera
    {
        public event InformacionDeAvance InformarAvance;
        public event InformacionLlegada InformarLlegada;

        private List<AutoF1> listaAutos;
        private int kms;

        public List<AutoF1> ListaAutos { get => this.listaAutos; set => this.listaAutos = value; }
        public int Kms { get => this.kms; set => this.kms = value; }

        public Carrera()
        {
            
        }

        public Carrera(int kms) : this()
        {
            this.kms = kms;
            this.listaAutos = new List<AutoF1>();
        }

        public void IniciarCarrera()
        {
            int posicion = 1;
            Task task = Task.Run(() =>
            {
                while (true)
                {
                    bool todosAsignados = true;

                    foreach (AutoF1 auto in this.ListaAutos)
                    {
                        if (auto.Posicion == 0)
                        {
                            todosAsignados = false;
                            auto.Acelerar();
                            Thread.Sleep(10);

                            if (auto.UbicacionEnPista >= this.Kms)
                            {
                                auto.Posicion = posicion;
                                posicion++;
                            }
                        }
                    }
                    if (todosAsignados)
                    {
                        break;
                    }
                }
            });
        }

        public static Carrera operator +(Carrera carrera, AutoF1 auto)
        {
            carrera.ListaAutos.Add(auto);

            return carrera;
        }
    }
}
