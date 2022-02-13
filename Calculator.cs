using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator:ICalculator
    {
        public int Sum(int first, int second)
        {
            return first + second;
        }
        public int Substract(int first, int second)
        {
            return first - second;
        }
        public int Multiply(int first, int second)
        {
            return first * second;
        }

    }
}
