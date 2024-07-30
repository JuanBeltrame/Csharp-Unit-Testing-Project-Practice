using _01._0._02_Extencion;

namespace _01._0._02_TestFizzBuzz
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void FizzBuzz_CuanddoEsDivisiblePorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 6;
            string expected = "Fizz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuanddoEsDivisiblePorCinco_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 10;
            string expected = "Buzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuanddoEsDivisiblePorTresyCinco_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_CuanddoNoEsDivisiblePorTresNiCinco_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 4;
            string expected = numero.ToString();

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}