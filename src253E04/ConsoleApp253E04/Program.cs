double lado = 5, diagonalMayor = 8, diagonalMenor = 6, altura = 10;

double perimetro = Application.Figura253E04.Perimetro(lado);
double area = Application.Figura253E04.Area(diagonalMayor, diagonalMenor);
double volumen = Application.Figura253E04.Volumen(area, altura);
Console.WriteLine("Propiedades de un Rombo");

Console.WriteLine($"Perímetro: {perimetro}cm");
Console.WriteLine($"Área: {area}cm²");
Console.WriteLine($"Volumen: {volumen}cm³");