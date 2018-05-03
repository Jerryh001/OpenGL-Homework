using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class SupPoint
    {
        Tuple<double, double> data;
        public double X { get => data.Item1;
            set
            {
                data = new Tuple<double, double>(value, data.Item2);
            }
        }
        public double Y { get => data.Item2;
            set
            {
                data = new Tuple<double, double>(data.Item1, value);
            }
        }
        public double Length { get => Math.Sqrt(X * X + Y * Y); }
        public SupPoint(double x, double y)
        {
            data = new Tuple<double, double>(x, y);
        }
        public SupPoint(Tuple<double, double> point)
        {
            data = point;
        }
        public SupPoint(Point point)
        {
            data = new Tuple<double, double>(point.X, point.Y);
        }
        public static SupPoint operator +(SupPoint a, SupPoint b)
        {
            return new SupPoint(a.X + b.X, a.Y + b.Y);
        }
        public static SupPoint operator -(SupPoint a, SupPoint b)
        {
            return new SupPoint(a.X - b.X, a.Y - b.Y);
        }
        public static SupPoint operator *(double n, SupPoint p)
        {
            return new SupPoint(n * p.X, n * p.Y);
        }
        public static SupPoint operator /(SupPoint p, double n)
        {
            return new SupPoint(p.X / n, p.Y / n);
        }
        public static explicit operator SupPoint(Point point)
        {
            return new SupPoint(point);
        }
        public static SupPoint Interpolation(SupPoint a, SupPoint b, double p)
        {
            return new SupPoint(a.X * (1-p) + b.X *p, a.Y *(1- p) + b.Y * p);
        }
        public static double Dot(SupPoint a, SupPoint b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

    }
}
