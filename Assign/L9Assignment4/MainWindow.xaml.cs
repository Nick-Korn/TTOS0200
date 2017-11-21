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

namespace L9Assignment4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly double MaxHeat = 120.0d;
        private readonly double MaxHumidity = 100.0d;
        private readonly double MinValue = 0d;

        private double temperature;
        private double humidity;
        public double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                try
                {
                    if (value <= MaxHeat && value >= MinValue) temperature = value;
                    else
                    {
                        MessageBox.Show("Invalid temperature value, setting the to minimun.");
                        temperature = MinValue;
                        tempTxtBox.Text = temperature.ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        public double Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                try
                {
                    if (value <= MaxHumidity && value >= MinValue) humidity = value;
                    else
                    {
                        MessageBox.Show("Invalid humidity value, setting the to minimun.");
                        humidity = MinValue;
                        humTxtBox.Text = humidity.ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void inputTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = inputTxtBox.Text;

                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    s = "0";
                }

                inputTxtBox.Text = s;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)humClckBox.IsChecked)
                {
                    Humidity = double.Parse(inputTxtBox.Text);
                    humTxtBox.Text = Humidity.ToString("n2");
                }
                if ((bool)tempChckBox.IsChecked)
                {
                    Temperature = double.Parse(inputTxtBox.Text);
                    tempTxtBox.Text = Temperature.ToString("n4");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // get button Content string
                string buttonString = (((Button)sender).Content).ToString();
                inputTxtBox.Text += buttonString;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dotBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                inputTxtBox.Text += ",";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
