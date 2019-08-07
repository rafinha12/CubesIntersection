using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGPM
{
    class Line
    {
        decimal point_ini, point_end;
        public Line(decimal point_ini, decimal point_end)
        {
            this.point_ini = point_ini;
            this.point_end = point_end;
        }
        public decimal lineIntersection(Line l1)
        {
            decimal max_ini = Math.Max(this.point_ini, l1.point_ini);
            if (max_ini <= this.point_end && max_ini <= l1.point_end)
            {
                decimal min_end = Math.Min(this.point_end, l1.point_end);
                return min_end - max_ini;
            }
            else
                return 0;
        }
    }
}
