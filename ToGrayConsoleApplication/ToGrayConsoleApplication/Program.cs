using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ToGrayConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = "../../image.jpg";
            Bitmap image = new Bitmap(fileName);
            int x, y;

            // Loop through the images pixels to reset color.
            for (x = 0; x < image.Width; x++)
            {
                for (y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int Gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color newColor = Color.FromArgb(Gray, Gray, Gray);
                    image.SetPixel(x, y, newColor); // Now greyscale
                }
            }

            String newFileName = fileName + "_gray.jpg";
            image.Save(newFileName);
        }
    }
}
