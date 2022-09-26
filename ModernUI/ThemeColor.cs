using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI
{
    internal class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>()
        {
            "#752dfe",
            "#fe6680",
            "#ad8039",
            "#ea6078",
            "#8e54d3",
            "#08c85f",
            "#27d8d0",
            "#f054fb",
            "#503fec",
            "#13c1d2",
            "#1f79aa",
            "#a466c0"
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            
            // If correction factor < 0, darken
            if (correctionFactor < 0)
            {
                correctionFactor++;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
            // If correction factor is greater
        }
    }
}
