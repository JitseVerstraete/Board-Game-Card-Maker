using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FirstStepsCardMaker.Model
{
    internal class BaseCard
    {
        public ImageSource Image
        {
            get
            {
                return new BitmapImage();
            }
        }

    }
}
