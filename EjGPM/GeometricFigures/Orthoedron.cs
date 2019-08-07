using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGPM.GeometricFigures
{
    class Orthoedron : Figure
    {
        public decimal depth, height, width;
        public Orthoedron()
        {
        }
        public Orthoedron(decimal height, decimal width, decimal depth, int x, int y, int z)
        {
            this.depth = depth;
            this.width = width;
            this.height = height;
            this.x = x;
            this.z = z;
            this.y = y;
        }

        
        public override decimal OrthoedronIntersection(Orthoedron o)
        {
            //get all the lines of each plane x, y and z
            Line height1 = new Line(this.y - (this.height/2), this.y + (this.height/2));
            Line heigth2 = new Line(o.y - (o.height/2), o.y + (o.height/2));
            Line width1 = new Line(this.x - (this.width/2), this.x + (this.width/2));
            Line width2 = new Line(o.x - (o.width/2), o.x + (o.width/2));
            Line depth1 = new Line(this.z - (this.depth/2), this.z + (this.depth/2));
            Line depth2 = new Line(o.z - (o.depth/2), o.z + (o.depth/2));
            //Calculate the intersection in 1D
            decimal height_intersection = height1.lineIntersection(heigth2);
            decimal width_intersection = width1.lineIntersection(width2);
            decimal depth_intersection = depth1.lineIntersection(depth2);
            //If all dimension have intersection
            if (height_intersection != 0 && width_intersection != 0 && depth_intersection != 0)
            {
                //Build an orthoedron and calculate the volume
                Orthoedron ort_result = new Orthoedron(height_intersection, width_intersection, depth_intersection, 0, 0, 0);
                return ort_result.Volume();
            }
            else
            {
                //The 2 cubes have not intersection
                return 0;
            }
        }

        public override decimal Volume()
        {
            return this.depth * this.height * this.width;
        }
    }
}
