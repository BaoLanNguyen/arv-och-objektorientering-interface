using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public class Triangle: IShape
    {
        public void Area(int width, int height){
            Console.WriteLine(width*height/2);
        }
        public void Circumferance(int width, int height){
            double pyth = Math.Sqrt(width*width+height*height);
            Console.WriteLine((int)pyth + width + height);
        }
    }
}
