namespace TestApp;

class Figure
{
    public static double GetAreaCircle(double radius) =>
        Math.PI * radius * radius;

    public static double GetAreaTriangle(double a, double b, double c)
    {
        var p = GetSemiPerimeter(a, b, c);

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public static double GetVolumeBall(double radius) =>
        ((double)4 / 3) * Math.PI * radius * radius * radius;

    public static bool IsTriangle(double a, double b, double c)
        => (a + b > c) && (a + c > b) && (b + c > a);

    private static double GetSemiPerimeter(double a, double b, double c) =>
        (a + b + c) / 2;
}