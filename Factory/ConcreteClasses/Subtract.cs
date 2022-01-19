using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CalculateFactory.ConcreteClasses
{
    internal class Subtract : ICalculate
    {
        public int Calculate(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
