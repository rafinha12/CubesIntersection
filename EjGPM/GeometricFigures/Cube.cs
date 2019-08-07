using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGPM.GeometricFigures
{
    //Cube class as a case of orthoedron with all arist equal
    class Cube : Orthoedron
    {
        public Cube(int arist, int x, int y, int z)
        {
            this.height = arist;
            this.width = arist;
            this.depth = arist;
            this.x = x;
            this.z = z;
            this.y = y;
        }
        

        
    }
}
