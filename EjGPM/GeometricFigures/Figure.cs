namespace EjGPM.GeometricFigures
{
    
    abstract class Figure
    {
        public int x;
        public int y;
        public int z;
        // Function that calculate volume of a Figure
        public abstract decimal Volume();
        // Function that calculate the intersection of a Figure and a orthoedron
        public abstract decimal OrthoedronIntersection(Orthoedron o);
    }


}


