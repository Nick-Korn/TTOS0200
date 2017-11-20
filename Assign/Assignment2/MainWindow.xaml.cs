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
            try
            {

                double amount = double.Parse(convTextBox.Text) * ExchangeRate;
                convdTextBox.Text = amount.ToString("n2") + "€";
            }
            catch (Exception ex)
            {

                errorTextBox.Text = ex.Message;
            }
        }
        public void ConvertToDollar()
        {

            try
            {
                double amount = double.Parse(convTextBox.Text) / ExchangeRate;
                convdTextBox.Text = amount.ToString("n2") + "$";
            }
            catch (Exception ex)
            {

                errorTextBox.Text = ex.Message;
            }
        }

        private void convTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Double.TryParse(convTextBox.Text, out double result))
                {
                    errorTextBox.Clear();
                    if (convdCoBox.SelectedIndex == 0)
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
                    convdTextBox.Clear();
                    errorTextBox.Text = "Invalid input";
                }

            }
            catch (Exception ex)
            {

                errorTextBox.Text = ex.Message;
            }
        }
    }
}
