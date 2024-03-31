using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Rectangle
    {
        private int width;
        private int height;

        public void SetDimensions(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetArea()
        {
            return width * height;
        }
    }
}
