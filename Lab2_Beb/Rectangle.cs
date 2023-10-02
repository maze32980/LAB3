namespace Lab2_Beb;

internal sealed class Rectangle
{
    private readonly double side1;
    private readonly double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
        Perimeter = CalculatePerimeter();
        Area = CalculateArea();
    }
    public double CalculateArea() => this.side1 * this.side2;

    public double CalculatePerimeter() => 2 * (this.side1 + this.side2);

    public double Area { get; }

    public double Perimeter { get; }
}