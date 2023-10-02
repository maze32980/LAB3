namespace Lab2_Beb;

internal class Program
{
    private static void Main(string[] args)
    {
        int taskNumber;
        Console.WriteLine("Enter task number: ");
        while (!int.TryParse(Console.ReadLine(), out taskNumber))
        {
            Console.WriteLine("Invalid input. Try again: ");
        }

        Console.WriteLine($"Task {taskNumber} selected");
        Action task = taskNumber switch
        {
            1 => Task1,
            2 => Task2,
            _ => () => Console.WriteLine("Task not found")
        };
        Run(task);

    }
    static void Run(Action task) => task();

    static void Task1()
    {
        double sideA, sideB;
        Console.WriteLine("Enter side A: ");
        while (!double.TryParse(Console.ReadLine(), out sideA))
        {
            Console.WriteLine("Invalid input. Try again: ");
        }

        Console.WriteLine("Enter side B: ");
        while (!double.TryParse(Console.ReadLine(), out sideB))
        {
            Console.WriteLine("Invalid input. Try again: ");
        }

        Rectangle rectangle = new(sideA, sideB);
        Console.WriteLine($"Area: {rectangle.Area}");
        Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
    }

    static void Task2()
    {
        int pointsCount;
        Console.WriteLine("Enter points count (3-5): ");
        while (!int.TryParse(Console.ReadLine(), out pointsCount) || pointsCount < 3 || pointsCount > 5)
        {
            Console.WriteLine("Invalid input. Try again: ");
        }
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Point[] points = new Point[pointsCount];
        for (int i = 0; i < pointsCount; i++)
        {
            double x, y;
            Console.WriteLine($"Enter point {i + 1} X: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input. Try again: ");
            }

            Console.WriteLine($"Enter point {i + 1} Y: ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Invalid input. Try again: ");
            }

            points[i] = new Point(x, y, alphabet[i].ToString());
        }

        Figure figure = new(points);
        var sideLength = figure.GetSideLength(point1: points[0], point2: points[1]);
        Console.WriteLine($"Side length: {sideLength}");
        figure.CalculatePerimeter();
    }
}
