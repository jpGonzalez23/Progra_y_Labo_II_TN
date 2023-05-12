using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModuleEquipoDeFutbol
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        /// <summary>
        /// Constructor privado 
        /// </summary>
        /// <param name="nombre"></param>
        private DirectorTecnico(string nombre):base(nombre) { }

        /// <summary>
        /// Sobrecaraga del constructor, Contructor para el ingreso de nombre y fecha de naciemto
        /// </summary>
        /// <param name="nombre">ingreso de nombre</param>
        /// <param name="fechaNacimiento"> ingreso de fecha de nacimiento</param>
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaDeNacimiento = fechaNacimiento;
        }

        /// <summary>
        /// Metodo para mostrar datos
        /// </summary>
        /// <returns>Retorna una cadena de caracteres</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento}");

            return sb.ToString();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return d1.Nombre == d2.Nombre && d1.fechaDeNacimiento == d2.fechaDeNacimiento;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
