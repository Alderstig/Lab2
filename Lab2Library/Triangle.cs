using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Lab2Library
{
    public class Triangle : Shape2D
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Triangle(Vector2 p1, Vector2 p2, Vector3 center)
        {
            this.p1 = p1;
            this.p2 = p2;
            p3.X = 3 * center.X - p1.X - p2.X;
            p3.Y = 3 * center.Y - p1.Y - p2.Y;
        }
        public override float Circumference => CalcDistance(p1.X, p1.Y, p2.X, p2.Y) 
            + CalcDistance(p2.X, p2.Y, p3.X, p3.Y) 
            + CalcDistance(p1.X, p1.Y, p3.X, p3.Y);

        public override Vector3 Center => new Vector3(CalcCentroid(p1.X, p2.X, p3.X), CalcCentroid(p1.Y, p2.Y, p3.Y), 0.0f);

        public override float Area => 0.25f *  MathF.Sqrt((CalcDistance(p1.X, p1.Y, p2.X, p2.Y) + CalcDistance(p2.X, p2.Y, p3.X, p3.Y) + CalcDistance(p1.X, p1.Y, p3.X, p3.Y)) 
            * (- CalcDistance(p1.X, p1.Y, p2.X, p2.Y) + CalcDistance(p2.X, p2.Y, p3.X, p3.Y) + CalcDistance(p1.X, p1.Y, p3.X, p3.Y))
            * (CalcDistance(p1.X, p1.Y, p2.X, p2.Y) - CalcDistance(p2.X, p2.Y, p3.X, p3.Y) + CalcDistance(p1.X, p1.Y, p3.X, p3.Y))
            * (CalcDistance(p1.X, p1.Y, p2.X, p2.Y) + CalcDistance(p2.X, p2.Y, p3.X, p3.Y) - CalcDistance(p1.X, p1.Y, p3.X, p3.Y)));

        private float CalcDistance (float x1, float x2, float y1, float y2)
        {
            float distance = MathF.Sqrt(MathF.Pow(x2 - x1, 2.0f) + MathF.Pow(y2 - y1, 2.0f) * 1.0f);
            return distance;
        }

        private float CalcCentroid(float d1, float d2, float d3)
        {
            return (d1 + d2 + d3) / 3;
        }
         
        public override string ToString()
        {
            return $"Triangle: ({CalcCentroid(p1.X, p2.X, p3.X)}, {CalcCentroid(p1.Y, p2.Y, p3.Y)}): p1: {p1.X}, {p1.Y} p2: {p2.X}, {p2.Y} p3: { p3.X}, { p3.Y})";
        }

        public IEnumerator GetEnumerator()
        {
            return new TriangleEnumerator(p1, p2, p3);
        }
    }
}
