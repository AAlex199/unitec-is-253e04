namespace Application;

public class Figura253E04

{
    public static double Perimetro(double lado)
    {
        return 4 * lado;
    }
    public static double Area(double diagonalMayor, double diagonalMenor) => (diagonalMayor * diagonalMenor) / 2;
    public static double Volumen(double areaBase, double altura) => areaBase * altura;
}

