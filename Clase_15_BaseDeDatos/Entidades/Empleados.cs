using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        public int id;
        public string nombre;
        public string apellido;
        public int idSector;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int IdSector { get => idSector; set => idSector = value; }

        public Empleados(int id, string nombre, string apellido, int idSector)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.idSector = idSector;
        }

        public Empleados(string nombre, string apellido, int idSector)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idSector = idSector;
        }
    }
}
