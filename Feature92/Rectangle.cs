namespace Feature92
{
    internal class Rectangle
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        public int Height { get; set; }
        public int Width { get; set; }
        internal void Deconstruct(out int height, out int width) //Deconstruct an object
        {
            height = Height;
            width = Width;
        }
    }
}
