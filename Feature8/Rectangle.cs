namespace Feature8;

public record Rectangle(int Height, int Width)
{
    public override string ToString() //apply sealed keyword to restrict child class to override
    {
        return $"height is: {Height}; width is: {Width}";
    }
}

public record Square : Rectangle
{
    public Square(int SideLength) : base(SideLength, SideLength)
    {
    }
    public override string ToString()
    {
        return $"Side length is: {Height}";
    }
}
