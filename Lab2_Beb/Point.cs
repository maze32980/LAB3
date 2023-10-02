namespace Lab2_Beb;

internal sealed class Point
{
    public Point(double x, double y, string pointName)
    {
        this.X = x;
        this.Y = y;
        this.Name = pointName;
    }

    public double X { get; }
    public double Y { get; }
    public string Name { get; }
}
