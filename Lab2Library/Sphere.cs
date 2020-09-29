using System;
using System.Numerics;

namespace Lab2Library
{
    public class Sphere : Shape3D
    {
        private Vector3 centerOfSphere;
        private float radiusOfSphere;
        public Sphere(Vector3 center, float radius)
        {
            centerOfSphere = center;
            radiusOfSphere = radius;
        }

        public override float Volume => (4.0f/3.0f) * MathF.PI * MathF.Pow(radiusOfSphere, 3.0f);
         
        public override Vector3 Center => new Vector3(centerOfSphere.X, centerOfSphere.Y, centerOfSphere.Z);

        public override float Area => 4.0f * MathF.PI * MathF.Pow(radiusOfSphere, 2.0f);

        public override string ToString()
        {
            return $"Sphere: ({centerOfSphere.X}, {centerOfSphere.Y}, {centerOfSphere.Z} Radius: {radiusOfSphere}";
        }
    }
    
}
