using System;
using Kokin.Nikita;

namespace Kokin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три параметра a, b, c: ");
            try
            {
                var a = float.Parse(Console.ReadLine());
                var b = float.Parse(Console.ReadLine());
                var c = float.Parse(Console.ReadLine());
                Nikita.Nikita.I.Log($"Введено уравнение {a}x^2{SetArithmeticSymbol(b)}{b}x{SetArithmeticSymbol(c)}{c}=0");
                new QuadraticEquation().Solve(a, b, c);
            }
            catch (FormatException formatException)
            {
                Nikita.Nikita.I.Log(formatException.Message);
            }
            catch (NikitaException nikitaException)
            {
                Nikita.Nikita.I.Log(nikitaException.Message);
            }

            Nikita.Nikita.I.Write();
            Console.ReadKey();

        }
        
        private static string SetArithmeticSymbol(float number) => number < 0 ? string.Empty : "+";
    }
}