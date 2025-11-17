using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Rectangle
    {
        public float Width;
        public float Height;

        public Rectangle() {
            Width = 1;
            Height = 1;
        }

        public Rectangle(float w, float h)
        {
            Width = w;
            Height = h;
        }

        public float Perimeter()
        {
            return (Width + Height) * 2; 
        }

        public float Area()
        {
            return Width * Height;
        }
    }
}
