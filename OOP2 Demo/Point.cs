using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Demo
{
    internal struct Point
    {
        //Attributes
        public int x;
        public int y;

        // in struct, compiler will always generate parametarless constructor
        // this constructor will initialize each and every object
        ///public Point()
        ///{
        ///    x = default;
        ///    y = default;
        ///}

        //Constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
