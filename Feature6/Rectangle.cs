namespace Feature6;
public struct Rectangle
{
    public Rectangle() //Paramter less struct is not available in c# 9
    {
        Height = 100;
        Width = 200;
    }
    public Rectangle(int hieght, int width)
    {
        Height = hieght;
        Width = width;
    }
    public int Height { get; set; }
    public int Width { get; set; }
}
