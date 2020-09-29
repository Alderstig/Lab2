using Lab2Library;
using System.Collections.Generic;
using System;
using System.Numerics;

namespace Lab2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            float volumeOf3DShape = 0.0f;
            float circumferenceOfTriangles = 0.0f;
            float averageArea = 0.0f; ;
            int shapecount = 1;

            List<Shape> shapes = new List<Shape>();

            for(int i = 0; i <= 20; i++)
            {
                shapes.Add(Shape.GenerateShape1());
            }

            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"Shape {shapecount}: {shape}");
                shapecount++;
                averageArea += shape.Area;

                if(shape is Triangle triangle)
                {
                    circumferenceOfTriangles += triangle.Circumference;
                }
                else if(shape is Shape3D shape3D)
                {
                    if(shape3D.Volume > volumeOf3DShape)
                    {
                        volumeOf3DShape = shape3D.Volume;
                    }
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine($"Average area of all shapes = {averageArea / 20}");
            Console.WriteLine($"Circumference of all triangles = {circumferenceOfTriangles}");
            Console.WriteLine($"The 3D-shape with the biggest volume had a volume of: {volumeOf3DShape}");
        }
    }
}
