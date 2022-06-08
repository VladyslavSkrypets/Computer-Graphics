namespace Lab1;

public class Point
{
    public Point(float x = 0, float y = 0, float z = 0)
    {
        X = x;
        Y = y;
        Z = z;

    }

    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    
    public void Print()
    {
        Console.WriteLine($"Point(x={X}, y={Y}, z={Z})");
    }
     // Add methods for operator overloading + and -
}