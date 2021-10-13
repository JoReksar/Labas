using System.Collections.Generic;

namespace Kokin.Core
{
    public interface IEquationInterface
    {
        public List<float> Solve(params float[] args);
    }
}