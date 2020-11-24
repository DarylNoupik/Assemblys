using System;
using System.Collections.Generic;
using System.Text;

namespace dll_point_Core
{
    class CLpoint
    {
        private static int initialse { get => initialse; set initialse= value; } = 0;
        private double _x
        {
            get => _x;
            set
            {
                if (_x >= 0) { _x = value; }

            }
        }
        private double _y
        {
            get => _y;
            set { if (_y >= 0) { _y = value; } }
        }

        public CLpoint()
        {
            this._x = 0;
            this._y = 0;
            int id = 0;
        }

        public CLpoint(double x, double y)
        {
            this._x = x;
            this._y = y;
            int id = 0;
        }

        public void init_point (double x ,double y)
        {
            
            
            if (new CLpoint())
            {
                initialse++;
                CLpoint.initialse = initialse;
            }else if(new CLpoint(x,y))
            {
                 initialse++;
            CLpoint.initialse = initialse;
               
            }
        }

    }
}
