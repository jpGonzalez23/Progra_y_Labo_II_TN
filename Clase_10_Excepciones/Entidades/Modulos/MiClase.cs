using Entidades.Exceptions;

namespace Entidades.Modulos
{
    public class MiClase
    {
        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <exception cref="UnaExcepcion"></exception>
        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw new MiExcepcion("Error en el método estático", ex); ;
            }
        }

        /// <summary>
        /// Sobrecarga del constructor
        /// </summary>
        /// <param name="ex"></param>
        /// <exception cref="UnaExcepcion"></exception>
        public MiClase(int id)
        {
            try
            {
                new MiClase();
            }
            catch (MiExcepcion miEx)
            {
                throw new UnaExcepcion("Error en el constructor MiClase(bool) que lanza UnaExcepcion.", miEx);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        private static void MetodoEstatico()
        {
            throw new DivideByZeroException("Error en el método estático. De MiClase().");
        }

    }
}