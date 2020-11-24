using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dll_point_Core
{
    class CLvoyage
    {
        private List<CLpoint> points ;
        public CLvoyage(List<CLpoint> ipoints)
        {
            this.points = ipoints;
        }

        void add (CLpoint lpoint)
        {
            this.points.Add(lpoint);
        }

        void del (CLpoint lpoint)
        {
            this.points.Remove(lpoint);
        }

        private double distanceVoyage()
        {
            
            double distance =0;
            int i;

            for(i=0; i < this.points.Count()-1; i++)
            {
                distance = distance + Math.Sqrt((Math.Pow((this.points[i + 1].Y - this.points[i].Y),2)) +
                (Math.Pow((this.points[i + 1].X - this.points[i].X),2) ));;
            }
            return distance;
        }
    }
}

