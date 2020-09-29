using System.Numerics;

namespace Lab2Library
{
    public class Cuboid : Shape3D
    {
        private Vector3 centerOfCuboid;
        private float sizeOfCuboidX;
        private float sizeOfCuboidY;
        private float sizeOfCuboidZ;

        public Cuboid(Vector3 center, Vector3 size)
        {
            centerOfCuboid = center;
            sizeOfCuboidX = size.X;
            sizeOfCuboidY = size.Y;
            sizeOfCuboidZ = size.Z;
        }

        public Cuboid(Vector3 center, float width)
        {
            centerOfCuboid = center;
            sizeOfCuboidX = width;
            sizeOfCuboidY = width;
            sizeOfCuboidZ = width;
        }

        public override float Volume => sizeOfCuboidX * sizeOfCuboidY * sizeOfCuboidZ;

        public override Vector3 Center => new Vector3(sizeOfCuboidX, sizeOfCuboidY, sizeOfCuboidZ);

        public override float Area => 2.0f * ((sizeOfCuboidY * sizeOfCuboidZ) + (sizeOfCuboidY * sizeOfCuboidX) + (sizeOfCuboidX * sizeOfCuboidZ));

        public bool IsCube
        {
            get
            {
                if (sizeOfCuboidX == sizeOfCuboidY && sizeOfCuboidY == sizeOfCuboidZ && sizeOfCuboidX == sizeOfCuboidZ)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            if (IsCube == true)
            {
                return $"Cube: ({centerOfCuboid.X}, {centerOfCuboid.Y} Width == Length == Height: {sizeOfCuboidX}";
            }
            else
            {
                return $"Cubeoid: ({centerOfCuboid.X}, {centerOfCuboid.Y} Width: {sizeOfCuboidY} Length: {sizeOfCuboidZ} Height: {sizeOfCuboidX}";
            }
        }
    }
}
