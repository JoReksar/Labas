using System;
using System.Collections.Generic;
using Kokin.Core;

namespace Kokin.Nikita
{
    public class QuadraticEquation : LinearEquation, IEquationInterface
    {
        public new List<float> Solve(params float[] args)
        {
            if (args.Length < 3)
                return base.Solve(args);
            
            if (args[0] == 0)
                return base.Solve(args[1], args[2]);

            NikitaLog.I.Log("Определено, что это квадратное уравнение");
            var discriminant = (args[1] * args[1]) - 4 * args[0] * args[2];

            if (discriminant < 0)
            {
                NikitaLog.I.Log("Решение уравнения находится в области комплексных чисел");
                return null;
            }

            if (discriminant == 0)
            {
                var x = -args[1] / (2 * args[0]);
                NikitaLog.I.Log($"Корень уравнения: x = {x.ToString()}");
                return new List<float>() {x};
            }

            var sqrtDiscriminant = (float) Math.Sqrt(discriminant);
            var x1 = (-args[1] + sqrtDiscriminant) / (2 * args[0]);
            var x2 = (-args[1] - sqrtDiscriminant) / (2 * args[0]);
            NikitaLog.I.Log($"Корни уравнения: x1 = {x1.ToString()}, x2 = {x2.ToString()}");
            return new List<float>() {x1, x2};
        }
    }
}