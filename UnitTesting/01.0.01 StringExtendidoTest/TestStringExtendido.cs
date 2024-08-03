using _01._0._01_StringExtendido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtendidoTest
{
    [TestClass]
    public class TestStringExtendido
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabras_DeberiaRetornarNumeroDos()
        {
            // Arrange
            string texto = "Hola Mundo";
            int expected = 2;

            // Act
            int actual = texto.ContarPalabras();


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ContarPlabras2_RecibeUnStringVacio_DeberiaLanzarArgumentException()
        {
            // Arrange
            string str = string.Empty;

            // Act
            int actual = str.ContarPalabras2();

            // Assert

        }

        [TestMethod]
        public void ContarPalabras3_CuandoRecibeDosPalabrasSeparadasPorGuion_DeberiaRetornarNumeroDos()
        {
            // Arrange
            string texto = "Hola-Mundo";
            int expected = 2;

            // Act
            int actual = texto.ContarPalabras3();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "Hl Mnd";    

            // Act 
            int actual = StringExtendido.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoNoTieneDosVocalEnMinuscula_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "casa";

            // Act 
            int actual = StringExtendido.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoNoTieneTresVocalEnMayuscula_DeberiaRetornarTres()
        {
            // Arrange
            int expected = 3;
            string text = "LA COSA";

            // Act 
            int actual = text.ContarVocales();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoNoTieneDosVocales_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "casa";

            // Act 
            int actual = StringExtendido.ContarVocales(text);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoElTextoEsNulo_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = null;

            // Act 
            int actual = text.ContarVocales();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ContarVocales_CuandoElTextoEsNulo_DeberiaLanzarBusinessException()
        {
            
          string text = null;

          text.ContarVocalesException();
        }

        [TestMethod]
        public void ContarCaracteres_CuandoNoTieneElCaracter_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string text = "trffjk jklk";
            char caracter = ';';

            // Act 
            int actual = text.ContarCaracteres(caracter);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCaracteres_CuandoTieneElCaracterDosVeces_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            string text = "trffjk. jklk.";
            char caracter = '.';

            // Act 
            int actual = text.ContarCaracteres(caracter);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCaracteres_CuandoElTextoEsNulo_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            string? text = null;
            char caracter = '.';

            // Act 
            int actual = text.ContarCaracteres(caracter);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ContarCaracteres_CuandoElTextoEsNulo_DeberiaLanzarBusinessException()
        {
            // Arrange
            int expected = 0;
            string? text = null;
            char caracter = '.';

            // Act 
            text.ContarCaracteresException(caracter);

            // Assert
        }
    }
}
