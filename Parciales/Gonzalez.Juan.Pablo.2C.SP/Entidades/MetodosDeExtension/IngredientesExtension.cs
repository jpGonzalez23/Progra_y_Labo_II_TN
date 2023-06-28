using Entidades.Enumerados;
using System.Linq;

namespace Entidades.MetodosDeExtension
{
    public static class IngredientesExtension
    {
        public static double CalcularCostoIngredientes(this List<EIngrediente> ingredientes, int costoInicial)
        {
            ingredientes.ForEach(ingrediente => costoInicial += (costoInicial * (int)ingrediente / 100));
            
            return costoInicial;
        }

        public static List<EIngrediente> IngredientesAletorios(this Random ramdom)
        {
            List<EIngrediente> ingredientes = new List<EIngrediente>()
            {
                EIngrediente.QUESO,
                EIngrediente.JAMON,
                EIngrediente.PANCETA,
                EIngrediente.HUEVO,
                EIngrediente.ADHERESO
            };

            int cant = ramdom.Next(1, ingredientes.Count + 1);

            return ingredientes.Take(cant).ToList();
        }

        //public double CalcularCostoIngredientes(List<EIngrediente> ingredientes, int costoInicial)
        //{
        //   foreach (EIngrediente ingrediente in ingredientes)
        //   {
        //       costoInicial += costoInicial * (int)ingrediente / 100;
        //   }
        //    return costoInicial;
        //}

        //public List<EIngrediente> IngredientesAletorios(Random ramdom)
        //{
        //    List<EIngrediente> ingredientes = new List<EIngrediente>()
        //    {
        //        EIngrediente.QUESO,
        //        EIngrediente.JAMON,
        //        EIngrediente.PANCETA,
        //        EIngrediente.HUEVO,
        //        EIngrediente.ADHERESO
        //    };

        //    ramdom.Next(1, ingredientes.Count + 1);
        //    return ingredientes.Take("acá va el numero aleatorio").ToList();
        //}
    }
}
