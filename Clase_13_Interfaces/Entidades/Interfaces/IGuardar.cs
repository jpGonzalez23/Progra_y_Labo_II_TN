﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IGuardar<T,V>
    {
        bool Guardar(T obj);
        V Leer();
    }
}
