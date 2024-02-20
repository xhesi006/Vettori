using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettori
{
    internal class Vector
    {
        private readonly double _x;
        private readonly double _y;

        public double X 
        { 
            get { return _x; } 
        }
        public double Y
        {
            get { return _y; }
        }
        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
        
        public static double operator *(Vector a, Vector b)
        {
            return (a.X * b.X + a.Y * b.Y);
        }
        public static Vector operator *(double a, Vector b)
        {
            return new Vector(a * b.X, a * b.Y);
        }
        public static Vector operator *(Vector a, double b) 
        {
            return new Vector(a.X * b, a.Y * b);
        }
        
        public static Vector operator /(Vector a, double b)
        {
            return new Vector(a.X/b, a.Y/b);
        }
        public static Vector operator +(Vector a)
        {
            return +a;
        }
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.X, -a.Y);
        }

        public double Modulo(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        
    }
}
