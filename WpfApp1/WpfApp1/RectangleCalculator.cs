using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class SimpsonCalculator : ICalculatorIntegral
    {
        public double Calculate(double lower, double upper, int count, Func<double, double> func)
        {
            if (count % 2 != 0)
            {
                throw new ArgumentException("Количество разбиений должно быть четным для метода Симпсона.");
            }

            double step = (upper - lower) / count;
            double sum = func(lower) + func(upper);

            for (int i = 1; i < count; i += 2)
            {
                sum += 4 * func(lower + i * step);
            }

            for (int i = 2; i < count - 1; i += 2)
            {
                sum += 2 * func(lower + i * step);
            }

            return sum * step / 3;
        }
    }

}
