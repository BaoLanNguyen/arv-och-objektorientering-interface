using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public class Triangle: IShape
    {
        int width;
        int height;

        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area(){
            return width*height/2;
        }
        public int Circumference(){
            double pyth = Math.Sqrt(width*width+height*height);
            return (int)pyth+width+height;
        }
    }
}
