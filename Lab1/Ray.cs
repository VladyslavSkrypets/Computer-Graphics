namespace Lab1;

public class Ray
{
    public Ray(Point point, Vector vector)
    {
        _Point = point;
        _Vector = vector;
    }
    
    public Point _Point { get; set; }
    public Vector _Vector { get; set; }
}