using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Modelos;

namespace TestHamburgueseria
{
    [TestClass]
    public class TestCocina
    {
        [TestMethod]
        [ExpectedException(typeof (FileManagerException))]
        public void AlGuardarUnArchivo_ConNombreInvalido_TengoUnaExcepcion()
        {
            //arrange
            
            FileManager.Guardar("Hola Mundo", null, false);
            
            //act

            //assert

        }

        [TestMethod]
        public void AlIsntanciarUnCocinero_SeEspera_PedidosCero()
        {
            Cocinero<Hamburguesa> cocinero = new Cocinero<Hamburguesa>("Pepito");
            
            int valorEsperado = 0;

            Assert.AreEqual(cocinero.CantPedidosFinalizados, valorEsperado);
        }
    }
}