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

namespace rekenMachine
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
        //delen door knopje
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = double.Parse(getal1.Text);
            double secondNum = double.Parse(getal2.Text);
            double result = firstNum / secondNum;
            string result1 = result.ToString();
            resultaat.Text = result1;
        }
        //plus knopje 
        private void Btnplus_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = double.Parse(getal1.Text);
            double secondNum = double.Parse(getal2.Text);
            double result = firstNum + secondNum;
            string result1 = Convert.ToString(result);
            resultaat.Text = result1;
        }
        //maal knopje
        private void times_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = double.Parse(getal1.Text);
            double secondNum = double.Parse(getal2.Text);
            double result = firstNum * secondNum;
            string result1 = Convert.ToString(result);
            resultaat.Text = result1;
        }
        //min knopje
        private void min_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = double.Parse(getal1.Text);
            double secondNum = double.Parse(getal2.Text);
            double result = firstNum - secondNum;
            string result1 = Convert.ToString(result);
            resultaat.Text = result1;
        }
        //int i=9
        //for i<10 i--
        private void resultaat_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Wissen(object sender, RoutedEventArgs e)
        {
            resultaat.Text = string.Empty;
            getal1.Text = string.Empty;
            getal2.Text = string.Empty;
        }
    }
}
