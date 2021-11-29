using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EncapsulationOrnek
{
    class Daire
    {
        //private double pi = 3;
        public double pi { get; set; }

        public double radius { get; set; }
        public double Radius
        {
            get
            {
                if (radius > 0d)
                {
                    this.radius = radius;
                }
                return radius;
            }
            
        }
        public Daire()
        {
            pi = 3;
        }
        public Daire(double userPi, double radius)
        {
            pi = userPi;
            this.radius = radius;
        }

        public void Cevre()
        {
            double cevre = 2 * pi * radius;
            Console.WriteLine("Dairenin çevresi : " + cevre);
        }
        public void Alan()
        {
            double alan = radius * radius * pi;
            Console.WriteLine("Dairenin alanı : " + alan);
        }

    }
}
