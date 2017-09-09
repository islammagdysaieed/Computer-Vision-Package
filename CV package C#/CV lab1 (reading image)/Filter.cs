using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace CV_lab1__reading_image_
{
    public enum FilterType { Mean, VerticalSobel, HorizontalSobel }
    public static class Filter
    {
        public static FilterType SelectedFilter;
        public static int SelectedFilter_KernelSize;
        public static RGBPixel[,] ApplyFilter(RGBPixel[,] orignal, FilterType filterType, int KernelSize)
        {
            RGBPixel[,] paddedImg = Image_Padding(orignal, KernelSize);
            RGBPixel[,] outputImage = FilterProcess(paddedImg, filterType, KernelSize / 2);
            return outputImage;
        }
        private static RGBPixel[,] FilterProcess(RGBPixel[,] orignal, FilterType filterType, int PaddingValue)
        {
            int Height = ImageOperations.GetHeight(orignal);
            int Width = ImageOperations.GetWidth(orignal);

            RGBPixel[,] outputImage = new RGBPixel[(Height - (PaddingValue * 2)), (Width - (PaddingValue * 2))];
            //int [,]Mask = new int[3,3];
            double[,] Mask = GenetrateMask(filterType);
            double RMax = InputImageInfo.maxValue;
            double RMin = InputImageInfo.minValue;
            for (int i = PaddingValue; i < Width - 1; i++)
            {
                for (int j = PaddingValue; j < Height - 1; j++)
                {
                    double R = 0, G = 0, B = 0;
                    int m = i - PaddingValue;
                    int n = j - PaddingValue;
                    for (int k = 0; k < 3; k++)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            R += orignal[n + z, m + k].red * Mask[z, k];
                            G += orignal[n + z, m + k].green * Mask[z, k];
                            B += orignal[n + z, m + k].blue * Mask[z, k];
                        }
                    }
                    if (filterType == FilterType.VerticalSobel || filterType == FilterType.HorizontalSobel)
                    {
                        if (R > 255 || G > 255 || B > 255 || R < 0 || G < 0 || B < 0)
                            outputImage[n, m] = new RGBPixel(0, 0, 0);
                        else
                            outputImage[n, m] = new RGBPixel((byte)R, (byte)G, (byte)B);
                    }
                    else
                        outputImage[n, m] = new RGBPixel((byte)R, (byte)G, (byte)B);

                }
            }
            return outputImage;
        }
        private static RGBPixel[,] Image_Padding(RGBPixel[,] orignal, int kernalsize)
        {
            int Height = ImageOperations.GetHeight(orignal);
            int Width = ImageOperations.GetWidth(orignal);

            int paddingValue = (kernalsize / 2);
            RGBPixel[,] paddingImage = new RGBPixel[Height + (paddingValue * 2), Width + (paddingValue * 2)];
            int paddingHeight = ImageOperations.GetHeight(paddingImage);
            int paddingWidth = ImageOperations.GetWidth(paddingImage);
            for (int i = 0; i < paddingValue; i++)
            {
                for (int j = 0; j < paddingWidth; j++)
                    paddingImage[i, j] = new RGBPixel(0, 0, 0);

                for (int j = 0; j < paddingWidth; j++)
                    paddingImage[Height + i, j] = new RGBPixel(0, 0, 0);

                for (int j = 0; j < paddingHeight; j++)
                    paddingImage[j, i] = new RGBPixel(0, 0, 0);

                for (int j = 0; j < paddingHeight; j++)
                    paddingImage[j, Width + i] = new RGBPixel(0, 0, 0);
            }

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    paddingImage[j + paddingValue, i + paddingValue] = orignal[j, i];
                }
            }
            return paddingImage;
        }
        private static double[,] GenetrateMask(FilterType filterType)
        {
            double[,] medianMask = { { .111111, .111111, .111111 }, { .111111, .111111, .111111 }, { .111111, .111111, .111111 } };
            double[,] sobelVerticalMask = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            //{ { 1, 0, -1 }, { 2, 0, -2 }, { 1, 0, -1 } };
            double[,] sobelHorizontalMask = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
            //{ { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            if (filterType == FilterType.Mean)
                return medianMask;
            else if (filterType == FilterType.HorizontalSobel)
                return sobelHorizontalMask;

            else if (filterType == FilterType.VerticalSobel)
                return sobelVerticalMask;
            else
                return medianMask;
        }
    }
}
