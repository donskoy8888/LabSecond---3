class Point
{
    private double x;
    private double y;
    private string name;

    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y; }
        set { y = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}