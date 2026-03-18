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
        public string Verbose()
        {
            return String.Format("{0};{1};{2}", this.x, this.y, this.z);
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
        public static double operator*(Vector a, Vector b)
        {
            var scalyre = ((a.x * b.x) + (a.y * b.y) + (a.z * b.z));
            return scalyre;
        }
    }
}
