using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class A
    {
        private int a;
        private int b;

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double CalculateExpression()
        {
            return (1.0 / (a * a)) - (1.0 / (b * b * b));
        }

        
        public int CubeOfSum()
        {
            return (a + b) * (a + b) * (a + b);
        }
    }

}
