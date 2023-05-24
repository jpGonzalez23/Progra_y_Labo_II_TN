namespace Entidades
{
    public class Sobrescrito
    {
        public override string ToString()
        {
            return "¡Este es mi metodo ToString sobrescrito!";
        }

        public override bool Equals(object? obj)
        {
            return obj is Sobrescrito;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}