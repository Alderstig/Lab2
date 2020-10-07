using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Lab2Library;

namespace Lab2Library
{
    class TriangleEnumerator : IEnumerator
    {
        private Vector2[] trianglePoints;
        private int count = -1;

        public TriangleEnumerator(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            trianglePoints = new Vector2[] {p1, p2, p3 };
        }
        public object Current
        {
            get { return trianglePoints[count]; }
        }

        public bool MoveNext()
        {
            if (count < trianglePoints.Length - 1)
            {
                count++;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void Reset()
        {
        }
    }
}
