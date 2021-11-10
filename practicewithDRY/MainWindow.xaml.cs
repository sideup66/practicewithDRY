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
using DRYpractice;

namespace practicewithDRY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        //create an object for our library        
        processor test = new processor();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //pass the numbers in the textbox to the library and get the result
            int result = test.add(Int32.Parse(num1.Text), Int32.Parse(num2.Text));
            lblSolution.Content = result.ToString();
        }

        private void btnsubtract_Click(object sender, RoutedEventArgs e)
        {
            //pass the numbers in the textbox to the library and get the result
            int result = test.subtract(Int32.Parse(num1.Text), Int32.Parse(num2.Text));
            lblSolution.Content = result.ToString();
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //pass the numbers in the textbox to the library and get the result
            int result = test.multiply(Int32.Parse(num1.Text), Int32.Parse(num2.Text));
            lblSolution.Content = result.ToString();
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            //pass the numbers in the textbox to the library and get the result
            double result = test.divide(Convert.ToDouble(num1.Text), Convert.ToDouble(num2.Text));
            lblSolution.Content = result.ToString();
        }
    }
}
