using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalculateIntegral();
        }
        public void CalculateIntegral()
        {
            ICalculatorIntegral calculator = null;
            double upperBound = Convert.ToDouble(tbUpperBound.Text);
            double lowerBound = Convert.ToDouble(tbLowerBound.Text);
            int count = Convert.ToInt32(tbcount.Text);
            Func<double, double> func = x => 32 * x - Math.Log(2 * x) - 41;
            /*if (calculator)
            {
                MessageBox.Show("Выберите метод интегрирования.");
                return;
            }*/
            double result = calculator.Calculate(lowerBound, upperBound, count, func);
            txtResult.Text = Convert.ToString(result);
        }

        public void cmbBoxIntegralType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ICalculatorIntegral calculator = null;
            switch (comboBox.SelectedIndex)
            {
                case 1:
                    calculator = new TrapezoidCalculator();
                    break;
                case 2:
                    calculator = new SimpsonCalculator();
                    break;
                default:
                    return;

            }

        }

    }
}