using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Intersection
{
    public class Rectangle
    {
        public string Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Top { get; set; }

        public int Left { get; set; }


        public Rectangle(string id, int w, int h, int top, int left)
        {
            this.Id = id;
            this.Width = w;
            this.Height = h;
            this.Top = top;
            this.Left = left;
        }

        public bool Intersect(Rectangle r)
        {


            return true;
        }
    }
}
