using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public class Circle: IShape
    {
        int width;
        int height;
        public Circle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int Area(){
            return (int)Math.PI * height* height / 4;
        }
        public int Circumference(){
            return (int)Math.PI * height;
        }
    }
}