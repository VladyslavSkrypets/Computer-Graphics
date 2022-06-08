namespace Lab1;

public class Sphere
{
    public Sphere(float radius, Point center)
    {
        Radius = radius;
        Center = center;
    }
    
    public float Radius { get; set; }
    public Point Center { get; set; } 
    
    // add method getNormal that gets point
}