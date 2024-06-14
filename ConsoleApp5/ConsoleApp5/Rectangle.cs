using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Rectangle
    {
        public string Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Top { get; set; }

        public int Left { get; set; }

        public bool Intersect(Rectangle other)
        {
            int thisRight = this.Left + this.Width;
            int thisBottom = this.Top + this.Height;
            int otherRight = other.Left + other.Width;
            int otherBottom = other.Top + other.Height;

            // Check for intersection
            bool intersectHorizontal = this.Left < otherRight && thisRight > other.Left;
            bool intersectVertical = this.Top < otherBottom && thisBottom > other.Top;

            return intersectHorizontal && intersectVertical;
        }

    }


}
