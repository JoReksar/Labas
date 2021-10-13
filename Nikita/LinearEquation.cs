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
                throw new NikitaException("Недостаточно аргументов для решения уравнения");
            
            if (args[0] == 0)
            {
                if (args[1] == 0)
                    throw new NikitaException("Ошибка: уравнение имеет бесконечное количество корней");
                throw new NikitaException("Ошибка: уравнение не имеет корней");
            }

            NikitaLog.I.Log("Определено, что это линейное уравнение");
            var x = -args[1] / args[0];
            NikitaLog.I.Log($"Корень уравнения: x = {x.ToString()}");
            return new List<float>() {x};
        }
    }
}