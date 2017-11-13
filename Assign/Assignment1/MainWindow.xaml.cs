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
            TruckCount = 0;
            CarCount = 0;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            truckTextBlock.Text = TruckCount.ToString();
            TruckCount++;
            truckTextBlock.Text = TruckCount.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            truckTextBlock.Text = TruckCount.ToString();
            CarCount++;
            carTextBlock.Text = CarCount.ToString();

        }
    }
}
