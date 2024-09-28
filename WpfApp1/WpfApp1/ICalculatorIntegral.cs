using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public interface ICalculatorIntegral
    {
        double Calculate(double lower, double upper,int count, Func<double,double>funk);

    }
}
