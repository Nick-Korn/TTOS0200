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

namespace L9Assignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<int> LottoLines { get; set; }
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                LottoLines = new List<int>();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void drawBtn_Click(object sender, RoutedEventArgs e)
        {

                int choice = gameCmbBox.SelectedIndex;
                int amount = 0;
                int scale = 0;
                bool starNumbers = false;
                resultTxtBox.Clear();
                LottoLines.Clear();
                switch (choice)
                {
                    case 0:
                        amount = 7;
                        scale = 40;
                        starNumbers = false;
                        break;
                    case 1:
                        amount = 6;
                        scale = 48;
                        starNumbers = false;
                        break;
                    case 2:
                        amount = 5;
                        scale = 50;
                        starNumbers = true;
                        break;
                    default:
                        MessageBox.Show("Invalid input for amount of draws");
                        break;
                }
                Lotto draw = new Lotto(amount, scale, starNumbers);
                //string lottoLine ="";
                for (int i = 0; i < int.Parse(drawTxtBox.Text); i++)
                {
                    LottoLines.Clear();
                    LottoLines = draw.DrawLottoLine();
                    resultTxtBox.Text += "Line " + i + ": ";
                    foreach (int number in LottoLines)
                    {
                        resultTxtBox.Text += number + " ";
                    }
                    resultTxtBox.Text += "\n";

                }



        }


        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                resultTxtBox.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
