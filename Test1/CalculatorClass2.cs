using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class CalculatorClass2
    {
        
        public int Add(int x, int y)
        {
            int z = x + y;
            return z;
        }
        public int Sub(int x, int y)
        {
            int z = x - y;
            return z;
        }
        public int Multi(int x, int y)
        {
            int z = x * y;
            return z;
        }
        public double Div(double x, double y)
        {
            double z = x / y;
            return z;
        }
    }
}
