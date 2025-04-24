using System;

namespace ConsoleApp1
{
    interface Ix
    {
        void IxF0(double parameter);
        void IxF1();
    }

    interface Iy
    {
        void F0(double parameter);
        void F1();
    }

    interface Iz
    {
        void F0(double parameter);
        void F1();
    }

    class TestClass : Ix, Iy, Iz
    {
        private double w;

        public TestClass(double w)
        {
            this.w = w;
        }

        public void IxF0(double parameter)
        {
            Console.WriteLine($"IxF0: {2 * Math.Sqrt(w)}");
        }

        public void IxF1()
        {
            Console.WriteLine($"IxF1: {w}");
        }

        public void F0(double parameter)
        {
            Console.WriteLine($"Iy.F0: {2}");
        }

        public void F1()
        {
            Console.WriteLine($"Iy.F1: {w}");
        }

        void Iz.F0(double parameter)
        {
            Console.WriteLine($"Iz.F0: {2}");
        }

        void Iz.F1()
        {
            Console.WriteLine($"Iz.F1: {w * w + 5}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                TestClass test = new TestClass(4.0);

            test.IxF0(1.0);
            test.IxF1();
            test.F0(1.0);
            test.F1();

            Ix ix = test;
            ix.IxF0(1.0);
            ix.IxF1();

            Iz iz = test;
            iz.F0(1.0);
            iz.F1();

            Console.ReadLine();
        }
    }
}
