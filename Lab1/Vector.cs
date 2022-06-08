namespace Lab1;

public class Vector: Point
{
    public Vector(float x = 0, float y = 0, float z = 0): base(x, y, z) {}

    public static Vector CrossProduct(Vector a, Vector b)
    {
        return new Vector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
    }

    public static float DotProduct(Vector a, Vector b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }
}