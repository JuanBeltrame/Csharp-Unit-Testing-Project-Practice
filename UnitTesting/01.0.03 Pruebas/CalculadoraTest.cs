using _01._0._03_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._0._03Pruebas
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Dividir_CuandoElDivisorEsCero_DeberiaRetornarDoubleMinValue()
        {
            //Arrange - Preparar el caso de prueba
            double divisor = 0;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = double.MinValue;

            // Act - Invocar el método a probar
            double resultado = calculadora.Dividir(2, divisor);

            // Assert - Verificar el resultado 
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        
        [TestMethod]
        public void Dividir_CuandoElDivisorEsIgualAlDividendo_DeberiaRetornarResultadoUno()
        {
            //Arrange - Preparar el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1;

            // Act - Invocar el método a probar
            double resultado = calculadora.Dividir(2, divisor);

            // Assert - Verificar el resultado 
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Dividir_CuandoElDivisorNoEsIgualAlDividendo_DeberiaRetornarResultadoDivision()
        {
            //Arrange - Preparar el caso de prueba
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1.5f;

            // Act - Invocar el método a probar
            double resultado = calculadora.Dividir(3, divisor);

            // Assert - Verificar el resultado 
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
