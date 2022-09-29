using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public class Rectangle : IShape
    {
        public void Area(int width, int height){
            Console.WriteLine(width*height);
        }
        public void Circumferance(int width, int height){
            Console.WriteLine(2*width+2*height);
        }

    }
}