using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public class Circle: IShape
    {
        public void Area(int width, int height){
            Console.WriteLine(Math.PI * height* height / 4);
        }
        public void Circumferance(int width, int height){
            Console.WriteLine(Math.PI * height);
        }
    }
}