using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class Test_Competencia
    {
        [TestMethod]
        public void ValidaListaInstanciada()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            //Act
            //Assert
            Assert.IsNotNull(competencia.ListadeVehiculos);
        }
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void ValidaExecpcionCompetenciaNoDisponible()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            MotoCross moto = new MotoCross(25, "Valentino");
            bool valida;
            //Act
            valida = competencia + moto;
            //Assert
        }
        [TestMethod]
        public void ValidaNoSeLanceExcepcion()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(25, "Valentino");
            //Act
            //Assert
            Assert.IsTrue(competencia + moto);
        }
        [TestMethod]
        public void ValidaAgregarVehiculoEnCompetencia()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(25, "Valentino");
            //Act           
            //Assert
            if (competencia + moto)
            {
                Assert.IsTrue(competencia == moto);
            }

        }
        [TestMethod]
        public void ValidaQuitarVehiculoEnCompetencia()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(25, "Valentino");
            //Act           
            //Assert
            if (competencia - moto)
            {
                Assert.IsTrue(competencia != moto);
            }

        }
    }
}