using Entidades.Enumerados;
using System.Linq;

namespace Entidades.MetodosDeExtension
{
    public class IngredientesExtension
    {
        public double CalcularCostoIngredientes(List<EIngrediente> ingredientes, int costoInicial)
        {
            foreach (EIngrediente ingrediente in ingredientes)
            {
                return costoInicial * ((int)ingrediente / 100);
            }
        }

        public List<EIngrediente> IngredientesAletorios(Random ramdom)
        {
            List<EIngrediente> ingredientes = new List<EIngrediente>()
            {
                EIngrediente.QUESO,
                EIngrediente.JAMON,
                EIngrediente.PANCETA,
                EIngrediente.HUEVO,
                EIngrediente.ADHERESO
            };

            ramdom.Next(1, ingredientes.Count + 1);
            return ingredientes.Take("acá va el numero aleatorio").ToList();
        }
    }
}
