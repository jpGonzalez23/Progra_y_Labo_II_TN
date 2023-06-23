using Entidades.DataBase;
using Entidades.Enumerados;
using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;
using System.Text;

namespace Entidades.Modelos
{
    public class Hamburguesa : IComestible
    {

        private static int costoBase;
        private bool esDoble;
        private double costo;
        private bool estado;
        private string imagen;
        List<EIngrediente> ingredientes;
        Random random;
        static Hamburguesa() => Hamburguesa.costoBase = 1500;


        public Hamburguesa() : this(false) { }
        public Hamburguesa(bool esDoble)
        {
            this.esDoble = esDoble;
            this.random = new Random();
        }

        public string Ticket => $"{this}\nTotal a pagar:{this.costo}";

        public bool Estado => this.estado;
        public string Imagen => this.imagen;


        private void AgregarIngredientes()
        {
            IngredientesExtension ingredienteExtension = new IngredientesExtension();

            this.random = new Random();

            this.ingredientes = ingredienteExtension.IngredientesAletorios(random);
        }

        private string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Hamburguesa {(this.esDoble ? "Doble" : "Simple")}");
            stringBuilder.AppendLine("Ingredientes: ");
            this.ingredientes.ForEach(i => stringBuilder.AppendLine(i.ToString()));
            return stringBuilder.ToString();

        }



        public override string ToString() => this.MostrarDatos();

        public void FinalizarPreparacion(string cocinero)
        {
            if (this.Estado)
            {
                IngredientesExtension ingredientesExtencion = new IngredientesExtension();
                this.costo = ingredientesExtencion.CalcularCostoIngredientes(this.ingredientes, Hamburguesa.costoBase);

                this.estado = false;
            }
        }

        public void IniciarPreparacion()
        {
            if (!this.Estado)
            {
                this.random = new Random();
                this.random.Next(1, 9);

                string imagen = $"Hamburguesa_{"Acá va el numero aleatorio"}";

                DataBaseManager.GetImagenComida(imagen);
                this.AgregarIngredientes();
                this.estado = true;
            }
        }
    }
}