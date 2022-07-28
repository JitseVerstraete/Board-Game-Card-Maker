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
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Interop;


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

            Bitmap image = new Bitmap(600, 600);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    System.Drawing.Color c = System.Drawing.Color.FromArgb((int)((i / (float)image.Width) * 255), (int)((j / (float)image.Height) * 255), 255);
                    image.SetPixel(i, j, c);
                }
            }


            var g = Graphics.FromImage(image);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Font f = new Font(new System.Drawing.FontFamily("Arial"), 20, System.Drawing.FontStyle.Regular);
            SolidBrush b = new SolidBrush(System.Drawing.Color.Black);
            g.DrawString("test", f, b, new PointF(300, 50), StringFormat.GenericDefault);




            im.Source = Imaging.CreateBitmapSourceFromHBitmap(image.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            image.Save("testImage.png", ImageFormat.Png);

        }
    }
}
