using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance();
    public delegate void InformacionLlegada();

    public class Carrera
    {
        public event InformacionDeAvance InformarAvance;
        public event InformacionLlegada InformarLlegada;

        private List<AutoF1> autos;
        private int kms;

        public List<AutoF1> Autos { get => this.autos; set => this.autos = value; }
        public int Kms { get => this.kms; set => this.kms = value; }

        public Carrera()
        {
            this.autos = new List<AutoF1>();
        }

        public Carrera(int kms):this()
        {
            this.kms = kms;
        }

        public void IniciarCarrera()
        {

        }

        public static Carrera operator +(Carrera carrera, AutoF1 auto)
        {

        }
    }
}
