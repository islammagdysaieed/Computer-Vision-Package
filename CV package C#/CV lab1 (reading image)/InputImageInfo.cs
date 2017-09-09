using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CV_lab1__reading_image_
{
   public static class InputImageInfo
    {
       public static RGBPixel[,]imgCopy;
       public static double maxValue;
       public static double minValue;
       public static void GetMinMaxRGBValues(RGBPixel[,] ImageMatrix)
        {
            int Height = ImageOperations.GetHeight(ImageMatrix);
            int Width = ImageOperations.GetWidth(ImageMatrix);
            double Max = -100000000000, Min = 10000000000000;
            for (int i = 0; i < Width; i++)
             {
                 for (int j = 0; j < Height; j++)
                {
                    double tmp = (double)ImageMatrix[j,i].red;
                    if (tmp > Max)
                        Max = tmp;
                    if (tmp < Min)
                        Min = tmp;
                }
                
             }
            minValue = Min;
            maxValue = Max;
        }
    }
}
