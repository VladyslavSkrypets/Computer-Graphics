namespace Lab1;

public class Scene
{
    Scene(Point start, Area area, int width = 20, int height = 20, float cellSize = 2)
    {
        _Area = area;
        _Start = start;
        _Width = width;
        _Height = height;
        _CellSize = cellSize;
    }

    public float _CellSize { get; set; }
    public Point _Start { get; set; }
    public Area _Area { get; set; }
    public int _Width { get; set; }
    public int _Height { get; set; }
}