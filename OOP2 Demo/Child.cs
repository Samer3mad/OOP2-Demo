using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Demo
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        
        public Child(int X, int Y, int Z) : base(X, Y)
        {
            this.Z = Z;
        }



    }
}
