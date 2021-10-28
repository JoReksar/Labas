using System;
using System.Collections.Generic;
using Lab.Core;

namespace Kokin.Nikita
{
    public class QuadraticEquation : LinearEquation, EquationInterface
    {
        public new List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
                return base.Solve(b, c, 0f);

            Nikita.I.Log("Определено, что это квадратное уравнение");
            var discriminant = (b * b) - 4 * a * c;

            if (discriminant < 0)
            {
                Nikita.I.Log("Решение уравнения находится в области комплексных чисел");
                return null;
            }

            if (discriminant == 0)
            {
                var x = -b / (2 * a);
                Nikita.I.Log($"Корень уравнения: x = {x}");
                return new List<float>() {x};
            }

            var sqrtDiscriminant = (float) Math.Sqrt(discriminant);
            var x1 = (-b + sqrtDiscriminant) / (2 * a);
            var x2 = (-b - sqrtDiscriminant) / (2 * a);
            Nikita.I.Log($"Корни уравнения: x1 = {x1}, x2 = {x2}");
            return new List<float>() {x1, x2};
        }
    }
}