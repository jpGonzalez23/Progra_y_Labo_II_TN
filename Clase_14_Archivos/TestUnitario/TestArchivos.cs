using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestArchivos
    {
        [TestMethod]
        public void VerificarSiExisteDirectorio_ExistingDirectory_ReturnsTrue()
        {
            string directorioExistente = "C:\\Ruta\\DirectorioExistente";
            bool resultado = Persistencia.VerificarSiExisteDirectorio(directorioExistente);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarSiExisteArchivo_ExistingFile_ReturnsTrue()
        {
            string archivoExistente = "C:\\Ruta\\ArchivoExistente.txt";
            bool resultado = Persistencia.VerificarSiExisteArchivo(archivoExistente);
            Assert.IsTrue(resultado);
        }
    }
}