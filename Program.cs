using System;
using System.Collections.Generic;

namespace Labas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class A
    {
        public float X { get; private set; }

        public List<float> SolveLinear(float a, float b)
        {
            if (a == 0)
            {
                if (b == 0)
                    throw new Exception("Уравнение имеет бесконечное количество решений");
                throw new Exception("Уравнение не имеет корней");
            }
            
            X = -b / a;
            return new List<float>() {X};
        }
    }

    class B : A
    {
        protected float FindDiscriminant(float a, float b, float c)
        {
            return (b * b) - 4 * a * c;
        }

        public List<float> Solve(float a, float b, float c)
        {

            if (a == 0)
            {
                return SolveLinear(b, c);
            }


            var discriminant = FindDiscriminant(a, b, c);
            if (discriminant < 0)
            {
                return null;
            }

            if (discriminant == 0)
            {
                var result = -b / (2 * a);
                return new List<float> { result };
            }

            var sqrtDisc = (float)Math.Sqrt(discriminant);
            var result1 = (-b + sqrtDisc) / (2 * a);
            var result2 = (-b - sqrtDisc) / (2 * a);
            return new List<float> { result1, result2 };
        }
    }


}