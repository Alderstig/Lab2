using System;
using System.Numerics;

namespace Lab2Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        public static Shape GenerateShape1()
        {
            switch (CreateRndInt())
            {
                case 1:
                    return new Circle(MyV2Size(), CreateRndFloat());    
                case 2:
                    return new Rectangle(MyV2Size(), MyV2Size());                   
                case 3:
                    return new Rectangle(MyV2Size(), CreateRndFloat());                    
                case 4:
                    return new Triangle(MyV2Size(), MyV2Size(), MyV2Size());                   
                case 5:
                    return new Sphere(MyV3Size(), CreateRndFloat());                  
                case 6:
                    return new Cuboid(MyV3Size(), MyV3Size());                   
                case 7:
                    return new Cuboid(MyV3Size(), CreateRndFloat());                    
                default:
                    return null;
            }
        }
       public static Shape GenerateShape2(Vector3 input)
        {
            Vector2 Center = new Vector2(input.X, input.Y);

            switch (CreateRndInt())
            {
                case 1:
                   return new Circle(Center, CreateRndFloat());
                case 2:
                    return new Rectangle(Center, MyV2Size());
                case 3:
                    return new Rectangle(Center, CreateRndFloat());
                case 4:
                    return new Triangle(MyV2Size(), MyV2Size(), input);
                case 5:
                    return new Sphere(input, CreateRndFloat());
                case 6:
                    return new Cuboid(input, MyV3Size());
                case 7:
                    return new Cuboid(input, CreateRndFloat());
                default:
                    return null;
            }
       }

        public static int CreateRndInt()
        {
            Random rnd = new Random();
            int randomInteger = rnd.Next(1, 8);

            return randomInteger;
        }

        public static float CreateRndFloat()
        {
            Random rnd2 = new Random();
            float randomFloat = (float)rnd2.NextDouble() * (101.0f - 1.0f) + 1.0f;

            return randomFloat;
        }

        public static Vector2 MyV2Size()
        {
            return new Vector2(CreateRndFloat(), CreateRndFloat());
        }

        public static Vector3 MyV3Size()
        {
            return new Vector3(CreateRndFloat(), CreateRndFloat(), CreateRndFloat());
        }
    }
}

