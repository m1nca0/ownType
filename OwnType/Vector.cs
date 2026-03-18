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
        public override string ToString()
        {
            return $"({this.x},{this.y},{this.z})";
        }
        public override bool Equals(object? obj)
        {
            var vector = obj as Vector;
            if (vector == null)
            {
                return false;
            }
            return (this.x == vector.x && this.y == vector.y && this.z == vector.z);
        }
        public double Len()
        {
            return Math.Sqrt((this.x * this.x) +  (this.y * this.y) + (this.z * this.z));
        }
        public static Vector operator+(Vector a,Vector b)
        {
            var newVector = new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
            return newVector;
        }
        public static Vector operator-(Vector a, Vector b)
        {
            var newVector = new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
            return newVector;
        }
        public static double operator *(Vector a, Vector b)
        {
            var scalyre = ((a.x * b.x) + (a.y * b.y) + (a.z * b.z));
            return scalyre;
        }
        public static Vector operator&(Vector a, Vector b)
        {
            var newVector = new Vector((a.y * b.z) - (a.z * b.y), (a.z * b.x) - (a.x * b.z), (a.x * b.y) - (a.y * b.x));
            return newVector;
        }

    }
}
