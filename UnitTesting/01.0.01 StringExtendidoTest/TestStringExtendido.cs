﻿using _01._0._01_StringExtendido;
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
        public void ContarPlabras_RecibeUnStringVacio_DeberiaLanzarArgumentException()
        {
            // Arrange
            string str = string.Empty;

            // Act
            int actual = str.ContarPalabras2();

            // Assert

        }

        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadasPorGuion_DeberiaRetornarNumeroDos()
        {
            // Arrange
            string texto = "Hola-Mundo";
            int expected = 2;

            // Act
            int actual = texto.ContarPalabras3();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}