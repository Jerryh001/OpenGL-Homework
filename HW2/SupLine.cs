using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class SupLine
    {
        public string Detail
        {
            get
            {
                return "(" + Begin.X.ToString() + "," + Begin.Y.ToString() + ") -> (" + End.X.ToString() + "," + End.Y.ToString() + ")";
            }
        }
        public SupPoint Begin { get; private set; }
        public SupPoint End { get; private set; }
        public SupPoint Vector { get => End - Begin; }
        public SupLine(SupPoint begin, SupPoint end)
        {
            Begin = begin;
            End = end;
        }
        static public SupLine Interpolation(SupLine a, SupLine b, double p)
        {
            SupPoint newbegin = SupPoint.Interpolation(a.Begin, b.Begin, p);
            SupPoint newend = SupPoint.Interpolation(a.End, b.End, p);
            return new SupLine(newbegin, newend);
        }
        public double GetProjectionScale(SupPoint p)
        {
            return SupPoint.Dot(p - Begin, Vector) / (Vector.Length * Vector.Length);
        }
        public double GetPerpendicularLength(SupPoint p)
        {
            return SupPoint.Dot(p - Begin, new SupPoint(Vector.Y, -Vector.X)) / Vector.Length;
        }

    }
}
