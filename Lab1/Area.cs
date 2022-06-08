namespace Lab1;

public class Area
{
    Area(Point a, Point b, Point c)
    {
        A = a;
        B = b;
        C = c;
    }
    
    public Point A { get; set; }
    public Point B { get; set; }
    public Point C { get; set; }
}