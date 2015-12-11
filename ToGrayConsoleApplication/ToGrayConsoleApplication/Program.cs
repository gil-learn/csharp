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
            Bitmap imageGray = (Bitmap)image.Clone();
            int x, y;

            // Loop through the images pixels to set color:

            // Lines:
            for (y = 0; y < image.Height; y++)
            {
                // Print progress:
                Console.WriteLine("Line " + y.ToString() + " out of " + image.Height.ToString() + " lines.");

                // Columns:
                for (x = 0; x < image.Width; x++)
                {

                    Color pixelColor = image.GetPixel(x, y);
                    int Gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color newColor = Color.FromArgb(Gray, Gray, Gray);
                    imageGray.SetPixel(x, y, newColor); // Now greyscale
                }
            }

            // Save new image:
            String newFileName = fileName + "_gray.jpg";
            imageGray.Save(newFileName);
        }
    }
}
