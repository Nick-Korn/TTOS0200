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

namespace Assignment3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int MaxValue = 3000;
        private readonly int MinValue = 300;

        private int windowHeight;
        private int windowWidth;
        public int WindowFrameWidth { get; set; }

        public int WindowHeight
        {
            get
            {
                return windowHeight;
            }
            set
            {
                try
                {
                    if (value <= MaxValue && value >= MinValue) windowHeight = value;
                    else
                    {
                        errorTextBox.Text += "Invalid window height, setting the value to minimun.\n";
                        windowHeight = MinValue;
                        windheightTextBox.Text = windowHeight.ToString();
                    }
                }
                catch (Exception ex)
                {

                    errorTextBox.Text = ex.Message;
                }
            }
        }
        public int WindowWidth
        {
            get
            {
                return windowWidth;
            }
            set
            {
                try
                {
                    if (value <= MaxValue && value >= MinValue) windowWidth = value;
                    else
                    {
                        errorTextBox.Text += "Invalid window width, setting the value to minimun.\n";
                        windowWidth = MinValue;
                        windwidthTextBox.Text = windowWidth.ToString();
                    }
                }
                catch (Exception ex)
                {

                    errorTextBox.Text = ex.Message;
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();

        }
        public void CalculateWindowArea(int height, int width, int frameWidth)
        {
            try
            {
                int area = (height + frameWidth) * (width + frameWidth);
                windowareaTextBox.Text = string.Format("{0} cm^2", area / 10);
            }
            catch (Exception ex)
            {

                errorTextBox.Text = ex.Message;
            }
            
        }
        public void CalculateGlassArea(int height, int width)
        {
            try
            {
                int area = height * width;
                glassareaTextBox.Text = string.Format("{0} cm^2", area / 10);
            }
            catch (Exception ex)
            {

                errorTextBox.Text = ex.Message;
            }
        }
        public void CalculateFrameCircumference(int height, int width, int frameWidth)
        {
            int cirucmference = 2 * (width + frameWidth) + 2 * (height + frameWidth);
            framecircumTextBox.Text = string.Format("{0} cm", cirucmference / 10);
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.TryParse(windwidthTextBox.Text, out int result) && int.TryParse(windheightTextBox.Text, out int result2) && int.TryParse(framewidthTextBox.Text, out int result3))
                {
                    errorTextBox.Clear();
                    frameCanvas.Children.Clear();
                    windowCanvas.Children.Clear();
                    WindowWidth = int.Parse(windwidthTextBox.Text);
                    WindowHeight = int.Parse(windheightTextBox.Text);
                    WindowFrameWidth = int.Parse(framewidthTextBox.Text);

                    CalculateFrameCircumference(WindowHeight, WindowWidth, WindowFrameWidth);
                    CalculateGlassArea(WindowHeight, WindowWidth);
                    CalculateWindowArea(WindowHeight, WindowWidth, WindowFrameWidth);

                    // Bonus 31
                    BrushConverter conv = new BrushConverter();
                    Rectangle frame = new Rectangle
                    {
                        Fill = conv.ConvertFromString("SaddleBrown") as SolidColorBrush,
                        Stroke = conv.ConvertFromString("Black") as SolidColorBrush,
                        Width = (WindowWidth + 2 * WindowFrameWidth) / 10,
                        Height = (WindowHeight + 2 * WindowFrameWidth) / 10
                    };
                    Canvas.SetTop(frame, -70);
                    Canvas.SetLeft(frame, -70);
                    frameCanvas.Children.Add(frame);

                    Rectangle glass = new Rectangle
                    {
                        Fill = conv.ConvertFromString("LightBlue") as SolidColorBrush,
                        Stroke = conv.ConvertFromString("Black") as SolidColorBrush,
                        Width = WindowWidth / 10,
                        Height = WindowHeight / 10
                    };
                    Canvas.SetLeft(glass, -70 + WindowFrameWidth / 10);
                    Canvas.SetTop(glass, -70 + WindowFrameWidth / 10);
                    windowCanvas.Children.Add(glass);

                    /*
                    BrushConverter conv = new BrushConverter();
                    glassRectangle.Width = WindowWidth / 10;
                    glassRectangle.Height = WindowHeight / 10;
                    glassRectangle.Fill = conv.ConvertFromString("LightBlue") as SolidColorBrush;
                    glassRectangle.Stroke = conv.ConvertFromString("Black") as SolidColorBrush;
                    frameRectangle.Width = (WindowWidth + WindowFrameWidth) / 10;
                    frameRectangle.Height = (WindowHeight + WindowFrameWidth) / 10;
                    frameRectangle.Stroke = conv.ConvertFromString("Black") as SolidColorBrush;
                    frameRectangle.Fill = conv.ConvertFromString("SaddleBrown") as SolidColorBrush;
                    */
                }
                else
                {
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
