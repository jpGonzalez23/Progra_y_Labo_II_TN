using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculoDeArea
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado"></param>
        /// <returns></returns>
        public static double CalculoCuadrado(double lado)
        {
            return lado * lado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroBase"></param>
        /// <param name="numeroAltura"></param>
        /// <returns></returns>
        public static double CalculoTriangulo(double numeroBase, double numeroAltura)
        {
            return (numeroBase * numeroAltura) / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radio"></param>
        /// <returns></returns>
        public static double CalculoCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
