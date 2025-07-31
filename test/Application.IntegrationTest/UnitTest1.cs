using System;
using Xunit;
using Application; // Asegúrate de que esta referencia sea correcta

namespace Application.IntegrationTest
{
    public class Figura253E04Test
    {
        // =========================================================================
        // PRUEBA PARA VOLUMEN DE ROMBO (usando diagonales y altura)
        // =========================================================================
        [Theory]
        [InlineData(10, 8, 6, 240)] // diagonalMayor = 10, diagonalMenor = 8, altura = 6, volumenEsperado = 240
        [InlineData(6, 4, 5, 60)]   // diagonalMayor = 6, diagonalMenor = 4, altura = 5, volumenEsperado = 60
        // Datos adicionales que combinan diagonales y altura para volumen
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
        public void TestVolumenDesdeRombo(double diagonalMayor, double diagonalMenor, double altura, double volumenEsperado)
        {
            // Arrange
            // La fórmula del volumen de un rombo es (Area_base * altura)
            // Y el Area_base de un rombo es (diagonalMayor * diagonalMenor) / 2
            double areaBase = Figura253E04.Area(diagonalMayor, diagonalMenor);

            // Act
            double resultadoVolumen = Figura253E04.Volumen(areaBase, altura);

            // Assert
            Assert.Equal(volumenEsperado, resultadoVolumen);
        }

        // =========================================================================
        // PRUEBA PARA PERÍMETRO (asumiendo que es de un cuadrado o rombo con lado)
        // =========================================================================
        // Nota: Si 'perimetro' es para un rombo, necesita un lado como parámetro.
        // Asumiendo que 'perimetro' en Figura253E04 toma un solo 'lado'.
        [Theory]
        [InlineData(3, 12)]  // Lado = 3, Perímetro = 12 (3 * 4)
        [InlineData(5, 20)]  // Lado = 5, Perímetro = 20
        [InlineData(7, 28)]
        [InlineData(8, 32)]
        [InlineData(10, 40)]
        [InlineData(6, 24)]
        [InlineData(9, 36)]
        [InlineData(4, 16)]
        [InlineData(2, 8)]
        [InlineData(1, 4)]
        public void TestPerimetroFigura(double lado, double perimetroEsperado)
        {
            // Arrange (no es necesario si el método es estático y no tiene estado)

            // Act
            double resultadoPerimetro = Figura253E04.Perimetro(lado);

            // Assert
            Assert.Equal(perimetroEsperado, resultadoPerimetro);
        }


        // =========================================================================
        // PRUEBA PARA ÁREA DE ROMBO
        // =========================================================================
        [Theory]
        [InlineData(6, 8, 24)]   // diagonalMayor = 6, diagonalMenor = 8, Area = 24
        [InlineData(10, 12, 60)] // diagonalMayor = 10, diagonalMenor = 12, Area = 60
        [InlineData(7, 9, 31.5)]
        [InlineData(5, 6, 15)]
        [InlineData(4, 10, 20)]
        [InlineData(8, 8, 32)]
        [InlineData(3, 7, 10.5)]
        [InlineData(9, 9, 40.5)]
        [InlineData(2, 6, 6)]
        [InlineData(1, 4, 2)]
        public void TestAreaRombo(double diagonalMayor, double diagonalMenor, double areaEsperada)
        {
            

            // Act
            double resultadoArea = Figura253E04.Area(diagonalMayor, diagonalMenor);

            // Assert
            Assert.Equal(areaEsperada, resultadoArea);
        }

        // =========================================================================
        // PRUEBA PARA VOLUMEN (usando Area_base y altura) - Si Figura253E04.Volumen toma area y altura
        // =========================================================================
       
        [Theory]
        [InlineData(24, 5, 120)]  // areaBase = 24, altura = 5, volumenEsperado = 120
        [InlineData(60, 3, 180)]
        [InlineData(31.5, 2, 63)]
        [InlineData(15, 4, 60)]
        [InlineData(20, 6, 120)]
        [InlineData(32, 3, 96)]
        [InlineData(10.5, 5, 52.5)]
        [InlineData(40.5, 2, 81)]
        [InlineData(6, 3, 18)]
        [InlineData(2, 5, 10)]
        public void TestVolumenDesdeAreaYAltura(double areaBase, double altura, double volumenEsperado)
        {
            

            // Act
            double resultadoVolumen = Figura253E04.Volumen(areaBase, altura);

            // Assert
            Assert.Equal(volumenEsperado, resultadoVolumen);
        }

    }
}