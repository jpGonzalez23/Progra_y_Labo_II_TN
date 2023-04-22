using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo
    {
        private Punto verticeUno;
        private Punto verticeDos;
        private Punto verticeTres;
        private Punto verticeCuatro;
        private float area;
        private float perimetro;

        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.verticeUno = vertice1;
            this.verticeTres = vertice3;
        }
    }
}
