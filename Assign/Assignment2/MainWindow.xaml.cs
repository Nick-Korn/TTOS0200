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

namespace Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double ExchangeRate { get; set; }
        public MainWindow()
        {
            ExchangeRate = 0.8997d;
            InitializeComponent();
        }
        public void ConvertToEuro()
        {

            double amount = double.Parse(convTextBox.Text) * ExchangeRate;
            convdTextBox.Text = amount.ToString("n2") + "€";
        }
        public void ConvertToDollar()
        { 

            double amount = double.Parse(convTextBox.Text) * ExchangeRate;
            convdTextBox.Text = amount.ToString("n2") + "$";
        }

        private void convTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Double.TryParse(convTextBox.Text, out double result))
            {
                
                if  (convdCoBox.SelectedIndex == 0)
                {
                    ConvertToDollar();
                }
                else if (convdCoBox.SelectedIndex == 1)
                {
                    ConvertToEuro();
                }
            }
            else
            {
                convdTextBox.Text = "Invalid input"; 
            }

        }
    }
}
