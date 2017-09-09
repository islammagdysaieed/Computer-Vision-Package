using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CV_lab1__reading_image_
{
    public static class Contrast
    {
        public static RGBPixel[,] Apply_Threshold(RGBPixel[,] ImageMatrix, double threshold)
        {
            int Height = ImageOperations.GetHeight(ImageMatrix);
            int Width = ImageOperations.GetWidth(ImageMatrix);
            RGBPixel[,] output = new RGBPixel[Height, Width];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    double tmp = (double)ImageMatrix[j, i].red;
                    if (tmp >= threshold)
                    {
                        output[j, i] = new RGBPixel(255, 255, 255);
                    }
                    if (tmp < threshold)
                    {
                        output[j, i] = new RGBPixel(0, 0, 0);
                    }
                }

            }
            return output;

        }
        public static RGBPixel[,] ContrastStretch(RGBPixel[,] ImageMatrix, double B)
        {
            int Height = ImageOperations.GetHeight(ImageMatrix);
            int Width = ImageOperations.GetWidth(ImageMatrix);
            RGBPixel[,] output = new RGBPixel[Height, Width];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    double R = (double)ImageMatrix[j, i].red;
                    double RMax = InputImageInfo.maxValue;
                    double RMin = InputImageInfo.minValue;
                    byte S = (byte)Math.Round(Math.Pow(2, B) * ((R - RMin) / (RMax - RMin)));
                    output[j, i] = new RGBPixel(S, S, S);
                }
            }
            return output;
        }
    }
}
