using System;
using System.Collections.Generic;
using System.Text;

namespace dll_point_Core
{
    class CLpoint
    {
        private static int initialse  = 0;
        private double _x;
        private double _y;
        public double X
        {
            get => _x;
            set
            {
                if (_x >= 0) { _x = value; }

            }
        }
        public double Y
        {
            get => _y;
            set { if (_y >= 0) { _y = value; } }
        }

        public CLpoint()
        {
            this._x = 0;
            this._y = 0;
            int id = 0;
            id = this.init_point();
        }

        public CLpoint(double x, double y)
        {
            this._x = x;
            this._y = y;
            int id = 0;
            id = this.init_point();
        }

        public int init_point ()
        {
           initialse++ ;
           return initialse ;

        }

        

    }
}


