using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_12
{
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public static double LengsVector(Point3D vector)
        {
            return Math.Round(Math.Sqrt(Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2) + Math.Pow(vector.Z, 2)),2);
        }
        public static double ABC(Point3D vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z);
        }
        public static Point3D operator + (Point3D left, Point3D right)
        {
            return new Point3D(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }
        public static Point3D operator - (Point3D left, Point3D right)
        {
            return new Point3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }
        public static Point3D operator - (Point3D left)
        {
            return new Point3D(-left.X,  -left.Y, -left.Z);
        }
        public static double operator * (Point3D left, Point3D right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }
        public override string? ToString()
        {
            return $"Координаты вектора: {X}, {Y}, {Z}";
        }
    }
}
