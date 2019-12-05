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
using Microsoft.VisualBasic;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }



        private void BtnNumbers(object sender, RoutedEventArgs e)
        {

            int num = Convert.ToInt32(Strings.Right(((Button)sender).Name, 1));
            if (operation == "")
            {
                number1 = (number1 * 10) + num;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + num;
                txtDisplay.Text = number2.ToString();
            }
        }
    }
}
