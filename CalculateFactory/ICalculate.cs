using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CalculateFactory
{
    public interface ICalculate
    {
        int Calculate(int num1, int num2);
    }
}
