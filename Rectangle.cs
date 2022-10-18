using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public class Rectangle : IShape
    {
        int width;
        int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int Area(){
            return width*height;
        }
        public int Circumference(){
            return 2*width+2*height;
        }

    }
}