using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ChainofResponsibilityCalculator
{
    public partial class MainWindow : Window
    {
        Chain chainCalculationAdd = new AddNumbers();
        Chain chainCalculationSubstract = new SubstractNumbers();
        Chain chainCalculationMultiply = new MultiplyNumbers();
        Chain chainCalculationDivide = new DivideNumbers();

        public MainWindow()
        {
            InitializeComponent();

            AddButton.IsEnabled = false;
            SubstractButton.IsEnabled = false;
            DivideButton.IsEnabled = false;
            MultiplyButton.IsEnabled = false;

            chainCalculationAdd.setNextChain(chainCalculationSubstract);
            chainCalculationSubstract.setNextChain(chainCalculationMultiply);
            chainCalculationMultiply.setNextChain(chainCalculationDivide);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers request = new Numbers(Int32.Parse(NumberOneField.Text), Int32.Parse(NumberTwoField.Text), "ADDITION");
            chainCalculationAdd.calculate(request, Result);
        }

        private void SubstractButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers request = new Numbers(Int32.Parse(NumberOneField.Text), Int32.Parse(NumberTwoField.Text), "SUBSTRACTION");
            chainCalculationAdd.calculate(request, Result);
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers request = new Numbers(Int32.Parse(NumberOneField.Text), Int32.Parse(NumberTwoField.Text), "MULTIPLICATION");
            chainCalculationAdd.calculate(request, Result);
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers request = new Numbers(Int32.Parse(NumberOneField.Text), Int32.Parse(NumberTwoField.Text), "DIVISION");
            chainCalculationAdd.calculate(request, Result);
        }

        private void NumberOneField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(NumberOneField.Text) && (!string.IsNullOrWhiteSpace(NumberTwoField.Text))))
            {
                AddButton.IsEnabled = true;
                SubstractButton.IsEnabled = true;
                DivideButton.IsEnabled = true;
                MultiplyButton.IsEnabled = true;
            }
        }

        private void NumberTwoField_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(NumberOneField.Text) && (!string.IsNullOrWhiteSpace(NumberTwoField.Text))))
            {
                AddButton.IsEnabled = true;
                SubstractButton.IsEnabled = true;
                DivideButton.IsEnabled = true;
                MultiplyButton.IsEnabled = true;
            }
        }
    }
}