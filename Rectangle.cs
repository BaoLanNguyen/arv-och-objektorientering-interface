using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public class Rectangle : IShape
    {
        public void Area(int width, int height){
            Console.WriteLine("Area is "+ width*height + ".");
        }
        public void Circumference(int width, int height){
            int omk = 2*width+2*height;
            Console.WriteLine("Circumference is " + omk +".");
        }

    }
}