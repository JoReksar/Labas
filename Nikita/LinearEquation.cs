using System.Collections.Generic;
using Lab.Core;

namespace Kokin.Nikita
{
    public class LinearEquation : EquationInterface
    {
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                if (b == 0)
                    throw new NikitaException("Ошибка: уравнение имеет бесконечное количество корней");
                throw new NikitaException("Ошибка: уравнение не имеет корней");
            }

            Nikita.I.Log("Определено, что это линейное уравнение");
            var x = -b / a;
            Nikita.I.Log($"Корень уравнения: x = {x}");
            return new List<float>() {x};
        }
    }
}