using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ToRGBConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = "../../image.jpg";
            Bitmap image = new Bitmap(fileName);
            Bitmap imageR = new Bitmap(image);
            Bitmap imageG = new Bitmap(image);
            Bitmap imageB = new Bitmap(image);
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
                    Color newColorR = Color.FromArgb(pixelColor.R, 0, 0);
                    Color newColorG = Color.FromArgb(0, pixelColor.G, 0);
                    Color newColorB = Color.FromArgb(0, 0, pixelColor.B);
                    imageR.SetPixel(x, y, newColorR);
                    imageG.SetPixel(x, y, newColorG);
                    imageB.SetPixel(x, y, newColorB);
                }
            }

            // Save new images:
            String newFileNameR = fileName + "_R.png";
            String newFileNameG = fileName + "_G.png";
            String newFileNameB = fileName + "_B.png";
            imageR.Save(newFileNameR);
            imageG.Save(newFileNameG);
            imageB.Save(newFileNameB);
        }
    }
}
