using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv_och_objektorientering_interface
{
    public interface IShape
    {
        void Area(int width, int height);
        void Circumference(int width, int height);
    }
}