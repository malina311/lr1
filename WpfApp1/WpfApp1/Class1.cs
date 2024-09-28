using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class TrapezoidCalculator : ICalculatorIntegral
    {
        public double Calculate(double lower, double upper, int count, Func<double, double> func)
        {
            double step = (upper - lower) / count;
            double sum = (func(lower) + func(upper)) / 2;

            for (int i = 1; i < count; i++)
            {
                sum += func(lower + i * step);
            }

            return sum * step;
        }
    }
}
