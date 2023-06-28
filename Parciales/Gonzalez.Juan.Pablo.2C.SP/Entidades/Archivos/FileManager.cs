using Entidades.Exceptions;
using Entidades.Interfaces;
using Entidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.Files
{
    public static class FileManager
    {
        private static string path;

        static FileManager()
        {
            //FileManager.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //FileManager.path += "\\Jua_Pablo_Gonzalez\\";

            FileManager.path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\20230622_Gonzalez_JP\\";

            FileManager.ValidarExistenciaDeDirectorio();
        }

        private static void ValidarExistenciaDeDirectorio() 
        {
            if (!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(FileManager.path);
                }
                catch (Exception ex)
                {
                    throw new FileManagerException("Error al crear el directorio\n", ex);
                }
            }
        }

        public static void Guardar(string data, string nombreArchivo, bool append)
        {
            //using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo))
            //{
            //    if (Path.GetExtension(nombreArchivo) == ".txt")
            //    {
            //        sw.WriteLine(data);
            //    }
            //    else
            //    {
            //        throw new FileManagerException("Entencion no valida");
            //    }
            //}

            try
            {
                using (StreamWriter sw = new StreamWriter(FileManager.path + nombreArchivo, append))
                {
                    sw.WriteLine(data);
                }
            }
            catch(Exception ex)
            {
                throw new FileManagerException("Erro al guardar un archivo de texto\n", ex);
                
            }
        }

        public static bool Serializar<T>(T elementos, string nombreArchivo)
            where T : class
        {
            //try
            //{
            //    string json = File.ReadAllText(FileManager.path + nombreArchivo);
            //    JsonConvert.DeserializeObject<T>(json);
            //    return true;
            //}
            //catch(Exception ex)
            //{
            //    throw new FileManagerException("Error al serializar archivo", ex);
            //    return false;
            //}

            try
            {
                FileManager.Guardar(System.Text.Json.JsonSerializer.Serialize(elementos, typeof(T)), nombreArchivo, false);
                return true;
            }
            catch(Exception ex)
            {
                throw new FileManagerException("Error al serializar ", ex);
            }
        }
    }
}
