namespace Lab1;

public class Vector
{
    public float X { get; }
    public float Y { get; }
    public float Z { get; }

    public Vector(float x = 0, float y = 0, float z = 0)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector(Point pointOne, Point pointTwo)
    {
        X = pointTwo.X - pointOne.X;
        Y = pointTwo.Y - pointOne.Y;
        Z = pointTwo.Z - pointOne.Z;
    }

    public Vector(Point point)
    {
        X = point.X;
        Y = point.Y;
        Z = point.Z;
    }

    public static Vector CrossProduct(Vector a, Vector b)
    {
        return new Vector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
    }

    public static float DotProduct(Vector a, Vector b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }

    public bool IsEqualTo(Vector vector)
    {
        return (int)X == (int)vector.X & (int)Y == (int)vector.Y & (int)Z == (int)vector.Z;
    }

    public static Vector operator +(Vector vectorOne, Vector vectorTwo)
    {
        return new Vector(vectorOne.X + vectorTwo.X, vectorOne.Y + vectorTwo.Y, vectorOne.Z + vectorTwo.Z);
    }
    
    public static Vector operator +(Vector vector, float value)
    {
        return new Vector(vector.X + value, vector.Y + value, vector.Z + value);
    }
    
    public static Vector operator -(Vector vectorOne, Vector vectorTwo)
    {
        return new Vector(vectorOne.X - vectorTwo.X, vectorOne.Y - vectorTwo.Y, vectorOne.Z - vectorTwo.Z);
    }
    
    public static Vector operator -(Vector vector, float value)
    {
        return new Vector(vector.X - value, vector.Y - value, vector.Z - value);
    }

    public static Vector operator *(Vector vector, float value)
    {
        return new Vector(vector.X * value, vector.Y * value, vector.Z * value);
    }

    public static Vector operator /(Vector vector, float value)
    {
        return new Vector(vector.X / value, vector.Y / value, vector.Z / value);
    }

    public static bool operator ==(Vector vectorOne, Vector vectorTwo)
    {
        return vectorOne.IsEqualTo(vectorTwo);
    }

    public static bool operator !=(Vector vectorOne, Vector vectorTwo)
    {
        return !vectorOne.IsEqualTo(vectorTwo);
    }

    public override bool Equals(object? obj)
    {
        return obj is Vector vector && this == vector;
    }
    public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
}