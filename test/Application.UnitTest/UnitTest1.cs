using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class Figura253E04Test
    {
        // Área del rombo: (d × D) / 2
        [Theory]
        [InlineData(6, 8, 24)]
        [InlineData(10, 12, 60)]
        [InlineData(7, 9, 31.5)]
        [InlineData(5, 6, 15)]
        [InlineData(4, 10, 20)]
        [InlineData(8, 8, 32)]
        [InlineData(3, 7, 10.5)]
        [InlineData(9, 9, 40.5)]
        [InlineData(2, 6, 6)]
        [InlineData(1, 4, 2)]
        public void TestAreaRombo(double dMayor, double dMenor, double esperado)
        {
            double resultado = Figura253E04.Area(dMayor, dMenor);
            Assert.Equal(esperado, resultado);
        }

        // Volumen: A × h
        [Theory]
        [InlineData(24, 5, 120)]
        [InlineData(60, 3, 180)]
        [InlineData(31.5, 2, 63)]
        [InlineData(15, 4, 60)]
        [InlineData(20, 6, 120)]
        [InlineData(32, 3, 96)]
        [InlineData(10.5, 5, 52.5)]
        [InlineData(40.5, 2, 81)]
        [InlineData(6, 3, 18)]
        [InlineData(2, 5, 10)]
        public void TestVolumenDesdeArea(double area, double altura, double volumenEsperado)
        {
            double resultado = Figura253E04.Volumen(area, altura);
            Assert.Equal(volumenEsperado, resultado);
        }

        // Volumen desde diagonales y altura
        [Theory]
        [InlineData(6, 8, 5, 120)]
        [InlineData(10, 12, 3, 180)]
        [InlineData(7, 9, 2, 63)]
        [InlineData(5, 6, 4, 60)]
        [InlineData(4, 10, 6, 120)]
        [InlineData(8, 8, 3, 96)]
        [InlineData(3, 7, 5, 52.5)]
        [InlineData(9, 9, 2, 81)]
        [InlineData(2, 6, 3, 18)]
        [InlineData(1, 4, 5, 10)]
        public void TestVolumenDesdeRombo(double dMayor, double dMenor, double altura, double volumenEsperado)
        {
            double area = Figura253E04.Area(dMayor, dMenor);
            double resultado = Figura253E04.Volumen(area, altura);
            Assert.Equal(volumenEsperado, resultado);
        }
    }
}
