using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades
{
    public class JsonFiler<T> : IMetodoArchivo<T>
    {
        public string GenerarRutaCompleta
        {
            get
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ruta += @"\JuanPabloGonzalez\";
                return ruta;
            }
        }

        public bool ExisteArchivo(string nombreArchivo)
        {
            if (!(Directory.Exists(this.GenerarRutaCompleta)))
            {
                try
                {
                    Directory.CreateDirectory(nombreArchivo);
                    return true;
                }
                catch(Exception e)
                {
                    throw new JsonFileException("Error al crear el directorio", e);
                }
            }
            return false;
        }

        public void Guardar(string archivo, T objeto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GenerarRutaCompleta + archivo))
                {
                    if (Path.GetExtension(archivo) == ".json")
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;
                        sw.WriteLine(System.Text.Json.JsonSerializer.Serialize<T>(objeto, options));
                    }
                }
            }
            catch(Exception ex)
            {
                throw new JsonFileException($"Error al guardar el archivo {archivo}", ex);
            }
        }

        public void Leer(string archivo, T objeto)
        {
            try
            {
                string rutaCompleta = this.GenerarRutaCompleta + archivo;
                string json = File.ReadAllText(rutaCompleta);
                
                objeto = JsonConvert.DeserializeObject<T>(json);

            }
            catch (Exception ex)
            {
                throw new JsonFileException($"Error al leer el archivo {archivo}", ex);
            }
        }
    }
}
