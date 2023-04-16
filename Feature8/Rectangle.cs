using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature8
{
    public record Rectangle(int Height,int Width)
    {
        public sealed  override string ToString()
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
}
