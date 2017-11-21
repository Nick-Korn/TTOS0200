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
        public List<string> LottoLines { get; set; }
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                LottoLines = new List<string>();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void drawBtn_Click(object sender, RoutedEventArgs e)
        {
            try
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
                string lottoLine;
                for (int i = 0; i < int.Parse(drawTxtBox.Text); i++)
                {
                    lottoLine = "Line " + (i + 1) + ": " + draw.DrawLottoLine();
                    LottoLines.Add(lottoLine);
                }
                foreach (var item in LottoLines)
                {
                    resultTxtBox.Text += item + "\n";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
