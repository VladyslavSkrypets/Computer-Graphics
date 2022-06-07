namespace Lab1;

public class Vector: Point
{
    public Vector(float x = 0, float y = 0, float z = 0): base(x, y, z)
    {
        Length = (float)Math.Sqrt(x * x + y * y + z * z);
    }
    
    public float Length { get; set; }
}