using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eXia_A2_sln_WS1
{
    class Program
    {
        static void Main(string[] args)
        {
            dll_pointCore.CLpoint point1;
            dll_pointCore.CLpoint point2;
            dll_pointCore.CLvoyage voyage;
            List<dll_pointCore.CLpoint> etapes;

            point1 = new dll_pointCore.CLpoint(1, 1);
            point2 = new dll_pointCore.CLpoint(2, 2);
            etapes = new List<dll_pointCore.CLpoint>(2);

            etapes.Add(point1);
            etapes.Add(point2);

            voyage = new dll_pointCore.CLvoyage(etapes);
            affichage(voyage);

            voyage.delPoint(point2);
            affichage(voyage);

            voyage.addPoint(new dll_pointCore.CLpoint());
            affichage(voyage);

            Console.WriteLine("Distance du voyage : {0}", voyage.distanceVoyage());
            Console.Read();
        }
        static void affichage(dll_pointCore.CLvoyage voyage)
        {
            int i;
            for (i = 0; i < voyage.getEtape().Count(); i++)
            {
                Console.WriteLine("Point  : {0} - {1} - {2}", voyage.getEtape()[i].getID(), voyage.getEtape()[i].getX(), voyage.getEtape()[i].getY());
            }
            Console.WriteLine("-------------------");
        }
    }
}

    }
}
