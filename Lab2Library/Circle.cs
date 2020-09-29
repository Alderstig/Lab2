using System;
using System.Numerics;

namespace Lab2Library
{
    public class Circle : Shape2D
    {
        private float radiusOfCircle;
        private Vector2 centerOfCircle;
        public Circle(Vector2 center, float radius)
        {
            radiusOfCircle = radius;
            centerOfCircle = center;
        }

        public override float Circumference => 2.0f * MathF.PI * radiusOfCircle;

        public override Vector3 Center => new Vector3(centerOfCircle.X, centerOfCircle.Y, 0.0f);

        public override float Area => (MathF.PI * MathF.Pow(radiusOfCircle, 2));

        public override string ToString()
        {
            return $"Circle: ({centerOfCircle.X}, {centerOfCircle.Y}) Radius: {radiusOfCircle}";
        }
    }
}
