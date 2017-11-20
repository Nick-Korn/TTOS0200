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

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int TruckCount { get; set; }
        public int CarCount { get; set; }
        public MainWindow()
        {
            try
            {
                TruckCount = 0;
                CarCount = 0;
                InitializeComponent();
            }
            catch (Exception ex)
            {

                erorrTextBox.Text = ex.Message; 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                truckTextBlock.Text = TruckCount.ToString();
                TruckCount++;
                truckTextBlock.Text = TruckCount.ToString();

            }
            catch (Exception ex)
            {

                erorrTextBox.Text = ex.Message; 
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                truckTextBlock.Text = TruckCount.ToString();
                CarCount++;
                carTextBlock.Text = CarCount.ToString();
            }
            catch (Exception ex)
            {

                erorrTextBox.Text = ex.Message;
            }

        }
    }
}
