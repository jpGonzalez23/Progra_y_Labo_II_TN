using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
//4.FileManager será estática.
//  a.En el constructor de clase realizar: 
//      i.En el atributo path se almacenará la referencia al escritorio de la pc.
//      Y se le concatenara un el nombre de la carpeta del parcial: ej {path escritorio}
//          +\\20220621SP\\
//      ii.Llamar al método ValidaExistenciaDeDirectorio.
//  b.ValidaExistenciaDeDirectorio:
//      i.Si no existe el directorio almacenado en path, se creará.
//      ii.En caso de producirse una excepción al momento de la creación, esta deberá ser capturada
//      y relanzada en una nueva excepción denominada FileManagerException,
//      la cual contendrá el mensaje: “Error al crear el directorio”.
//  c.Guardar:
//      i.Será genérico y solo permitirá que los elementos a almacenar sean tipos por referencia.
//      ii.Validar la extensión del nombre del archivo. En caso de que sea:
//          1.JSON, se serializará el elemento recibido.
//          2.TXT, se almacena en texto plano.
//          3.Cualquier otra extensión se lanzará una excepción denominada FileManagerException,
//          la cual contendrá el mensaje “Extensión no permitida”.

    public static class FileManager
    {
        private static string path;

        /// <summary>
        /// Constructor para inicializar el path de los archivos
        /// </summary>
        static FileManager() 
        {
            FileManager.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileManager.path += "\\Juan_Pablo_Gonzalez\\";
            ValidaExistenciaDeDirectorio();
        }

        /// <summary>
        /// Metodo para validar si la direccion existe
        /// </summary>
        /// <exception cref="FileManagerException">Se genera una exepcion por sino se crea el directorio</exception>
        public static void ValidaExistenciaDeDirectorio()
        {
            if (!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(FileManager.path);
                }
                catch(Exception ex)
                {
                    throw new FileManagerException("Error al crear el directorio", ex);
                }
            }
        }

        /// <summary>
        /// Metodo para guardar los archivos de tipo .json o .txt
        /// </summary>
        /// <typeparam name="T">Tiene que ser del tipo generica</typeparam>
        /// <param name="elemento">Nombre del elemento</param>
        /// <param name="nombreArchivo">nombre del archivo a recibir</param>
        public static void Guardar<T>(T elemento, string nombreArchivo) where T : class
        {
            //if (Path.GetExtension(nombreArchivo) == ".json")
            //{
            //    using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo))
            //    {
            //        JsonSerializerOptions opciones = new JsonSerializerOptions();
            //        opciones.WriteIndented = true;
            //        sw.WriteLine(JsonSerializer.Serialize<T>(elemento, opciones));
            //    }
            //}
            //else if (Path.GetExtension(nombreArchivo) == ".txt")
            //{
            //    using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo))
            //    {
            //        sw.WriteLine(elemento);
            //    }
            //}
            //else
            //{
            //    throw new FileManagerException("Extension no permitida");
            //}

            using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo))
            {
                if ((Path.GetExtension(nombreArchivo) == ".json"))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    sw.WriteLine(JsonSerializer.Serialize<T>(elemento, opciones));

                }
                else if ((Path.GetExtension(nombreArchivo) == ".txt"))
                {
                    sw.WriteLine(elemento);
                }
                else
                {
                    throw new FileManagerException("Extension no permitida");
                }
            }
        }
    }
}
