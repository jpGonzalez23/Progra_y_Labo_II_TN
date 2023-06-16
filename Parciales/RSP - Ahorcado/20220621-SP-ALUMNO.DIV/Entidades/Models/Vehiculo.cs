﻿using Entidades.DataBase;
using Entidades.Extension;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    //13.	Vehículo, implementará el mensaje ObtenerNuevaPalabra,
    //para ello deberá leer desde la tabla “Vehiculos” en base a un ID aleatorio(hasta 37).
    //Reutilizar código.
    public class Vehiculo : ILector
    {
        /// <summary>
        /// Metodo para obtener una nueva palabra
        /// </summary>
        /// <returns>Retorna la palabra obtenida del server</returns>
        public string ObtenerNuevaPalabra()
        {
            Random random = new Random();
            return DataBaseManager.GetNuevaPalabra("vehiculo", random.GetRandomId(38));
        }
    }
}
