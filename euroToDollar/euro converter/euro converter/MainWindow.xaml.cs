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

namespace euro_converter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //euro omzetten naar dollar
           double euroBedrag = double.Parse(textEuro.Text);
            double dollarBedrag = euroBedrag * 0.98;

            textDollar.Text =Convert.ToString(dollarBedrag);
             
        }

        private void wissen_Click(object sender, RoutedEventArgs e)
        {
            textDollar.Text = "";
            textEuro.Text = "";
        }
    }
}
//test