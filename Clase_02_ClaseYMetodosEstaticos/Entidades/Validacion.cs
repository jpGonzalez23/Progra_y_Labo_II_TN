namespace Entidades
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor < min && valor > max)
            {
                return true;
            }
            return false;
        }
    }
}