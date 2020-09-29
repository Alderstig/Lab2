using System.Numerics;

namespace Lab2Library
{
    public class Rectangle : Shape2D
    {
        private float sizeOfRectangleX;
        private float sizeOfRectangleY;
        private Vector2 centerOfRectangle;

        public Rectangle(Vector2 center, Vector2 size)
        {
            centerOfRectangle = center;
            sizeOfRectangleX = size.X;
            sizeOfRectangleY = size.Y;
        }

        public Rectangle(Vector2 center, float width)
        {
            centerOfRectangle = center;
            sizeOfRectangleX = width;
            sizeOfRectangleY = width;
        }

        public override float Circumference => 2.0f * (sizeOfRectangleX + sizeOfRectangleY);

        public override Vector3 Center => new Vector3(centerOfRectangle.X, centerOfRectangle.Y, 0.0f);

        public override float Area => sizeOfRectangleX * sizeOfRectangleY;

        public bool IsSquare
        {
            get
            { 
                if (sizeOfRectangleX.Equals(sizeOfRectangleY))
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
            if (IsSquare == true)
            {
                return $"Square: {centerOfRectangle.X}, {centerOfRectangle.Y} Height and Width: {sizeOfRectangleX}";
            }
            else
            {
                return $"Rectangle: ({centerOfRectangle.X}, {centerOfRectangle.Y}) Height: {sizeOfRectangleX} Width: {sizeOfRectangleY}";
            }
        }
    }
}
