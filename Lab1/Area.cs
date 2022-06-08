namespace Lab1;

public class Area
{
    Area(Point a, Point b, Point c)
    {
        var v1 = new Vector(b.X - a.X, b.Y - a.Y, b.Z - a.Z);
        var v2 = new Vector(b.X - c.X, b.Y - c.Y, b.Z - c.Z);
        N = Vector.CrossProduct(v1, v2);
        D = -(N.X * a.X + N.Y * a.Y + N.Z + a.Z);
    }

    Area(Vector n, float d)
    {
        N = n;
        D = d;
    }

    public Boolean IsOnArea(Point point)
    {
        return N.X * point.X + N.Y * point.Y + N.Z * point.Z + D == 0;
    }

    public Ray ReflectRay(Ray ray)
    {
        return ray;
    }

    public Vector N { get; set; }
    public float D { get; set; }
}