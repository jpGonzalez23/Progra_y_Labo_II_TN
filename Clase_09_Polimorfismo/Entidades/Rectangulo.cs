using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private double longiAltura;
        private double longiBase;

        public Rectangulo(float longiAltura, float longiBase)
        {
            this.longiAltura = longiAltura;
            this.longiBase = longiBase;
        }

        public override double CalcularPerimetro()
        {
            return (this.longiAltura + this.longiBase) * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.longiBase * this.longiAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando un rectángulo....";
        }
    }
}
