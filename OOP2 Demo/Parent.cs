using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Demo
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }

        public int Y { get; set; }
        #endregion

        #region Constructor
        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion

        #region Methods
        public int product()
        {
            return this.X * this.Y;
        }

        public override string ToString()
        {
            return $"X={X}\n Y={Y}";
        } 
        #endregion
    }
}
