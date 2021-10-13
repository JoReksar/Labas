using System;

namespace Labas
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new();
            A a2 = new();
            A a3 = new();
            B b4 = new() { Obj1 = a2 };
            C c5 = new() { Obj1 = a1, Obj2 = a3, Obj3 = b4 };
        }
    }

    class A { }

    class B : A
    {
        public object Obj1 { get; init; }
    }

    class C : B
    {
        public object Obj2 { get; init; }
        public object Obj3 { get; init; }
    }
}