using System.Text;

namespace Lab2_Beb;

internal sealed class Figure
{
    private readonly Point[] points;
    public Figure(params Point[] points)
    {
        if (points.Length < 3)
        {
            throw new ArgumentException("Figure must have at least 3 points");
        }

        if (points.Length > 5)
        {
            throw new ArgumentException("Figure must have no more than 5 points");
        }

        this.points = points;
    }

    public double GetSideLength(Point point1, Point point2)
    {
        return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
    }

    public void CalculatePerimeter()
    {
        StringBuilder name = new();
        var perimeter = 0.0;

        for(var i = 0; i < points.Length; i++)
        {
            name.Append(this.points[i].Name);
        }

        for (var i = 0; i < this.points.Length - 1; i++)
        {
            perimeter += GetSideLength(this.points[i], this.points[i + 1]);
        }

        perimeter /= this.points.Length;
        Console.WriteLine($"Perimeter: {perimeter} | Name: {name}");
    }
}
