using System;
using System.Collections.Generic;
using Kokin.Core;

namespace Kokin.Nikita
{
    public class LinearEquation : IEquationInterface
    {
        public List<float> Solve(params float[] args)
        {
            if (args.Length < 2)
                throw new Exception("Недостаточно аргументов для решения уравнения");
            
            if (args[0] == 0)
            {
                if (args[1] == 0)
                    throw new Exception("Ошибка: уравнение имеет бесконечное количество корней");
                throw new Exception("Ошибка: уравнение не имеет корней");
            }

            var x = -args[1] / args[0];
            return new List<float>() {x};
        }
    }
}