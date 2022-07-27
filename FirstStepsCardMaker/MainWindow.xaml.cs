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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Imaging;


namespace FirstStepsCardMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Bitmap image = new Bitmap(400, 400);
            
            for(int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color c = Color.FromArgb((int)((i / (float)image.Width) * 255) , (int)((j / (float)image.Height) * 255), 255);


                    var g =  Graphics.FromImage(image);

                    Font f = new Font(new FontFamily("Arial"), 20);
                    SolidBrush b = new SolidBrush(Color.Black);
                    g.DrawString("test", f, b, new PointF(200, 200), StringFormat.GenericDefault);

                    image.SetPixel(i, j, c);
                }
            }

            image.Save("testImage.png", ImageFormat.Png);
            
        }
    }
}
