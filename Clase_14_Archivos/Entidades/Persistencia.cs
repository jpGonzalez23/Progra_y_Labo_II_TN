namespace Entidades
{
    public static class Persistencia
    {
        public static bool VerificarSiExisteDirectorio(string direccion)
        {
            if (Directory.Exists(direccion))
            {
                return true;
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(direccion);
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            }
        }

        public static bool VerificarSiExisteArchivo(string archivo)
        {
            if (File.Exists(archivo))
            {
                return true;
            }
            else
            {
                try
                {
                    File.Create(archivo);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            }
        }
    }
}