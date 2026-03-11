using System;
using System.Collections.Generic;
using System.Text;

namespace OwnType
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Len()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public static Vector operator+(Vector a,Vector b)
        {
            var newVector = new Vector(a.x+b.x, a.y + b.y, a.z + b.z);
            return newVector;
        }
        public static Vector operator-(Vector a, Vector b)
        {
            var newVector = new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
            return newVector;
        }
        public static Vector operator*(Vector a, Vector b)
        {
            var scalyre = ((a.x * secondX) + (firstY * secondY) + (firstZ * secondZ))
            return newVector;
        }
    }
}
