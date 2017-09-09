using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Accord.Math;

//i,j is after RGBPixel modification
namespace CV_lab1__reading_image_
{

    public static class Harris
    {
        public static RGBPixel[,] featurePoints;
        public static int FeaturePointCount;
        public static RGBPixel[,] Harris_2(RGBPixel[,] originalImg)
        {
            RGBPixel[,] Ix = Filter.ApplyFilter(originalImg, FilterType.HorizontalSobel, 3);
            RGBPixel[,] Iy = Filter.ApplyFilter(originalImg, FilterType.VerticalSobel, 3);
            RGBPixel[,] Ix2 = Muliply_2_Image(Ix, Ix);
            RGBPixel[,] Iy2 = Muliply_2_Image(Iy, Iy);
            RGBPixel[,] IxIy = Muliply_2_Image(Ix, Iy);
            Ix2 = ImageOperations.GaussianFilter1D(Ix2, 7, 2);
            Iy2 = ImageOperations.GaussianFilter1D(Iy2, 7, 2);
            IxIy = ImageOperations.GaussianFilter1D(IxIy, 7, 2);
            RGBPixel Rmax;
            RGBPixel[,] R = CalculateHarrisCorener(Ix2,Iy2,IxIy,out Rmax);
            int count = 0;
            RGBPixel[,] result = CalculateRresults(R, Rmax ,out count);
            FeaturePointCount = count;
            return result;
        }
        private  static RGBPixel[,] Muliply_2_Image(RGBPixel[,] ImageMatrix1, RGBPixel[,] ImageMatrix2)
        {
            int Height = ImageOperations.GetHeight(ImageMatrix1);
            int Width = ImageOperations.GetWidth(ImageMatrix1);
            RGBPixel[,] mulResult = new RGBPixel[Height,Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    mulResult[i, j].red = (byte)(ImageMatrix1[i, j].red * ImageMatrix2[i, j].red);
                    mulResult[i, j].green = (byte)(ImageMatrix1[i, j].green * ImageMatrix2[i, j].green);
                    mulResult[i, j].blue = (byte)(ImageMatrix1[i, j].blue * ImageMatrix2[i, j].blue);
                }
            }
            return mulResult;
        }
        private  static RGBPixel[,] CalculateHarrisCorener(RGBPixel[,] Ix2, RGBPixel[,] Iy2, RGBPixel[,] IxIy, out RGBPixel Rmax)
        {
            int Height = ImageOperations.GetHeight(Ix2);
            int Width = ImageOperations.GetWidth(Ix2);
            RGBPixel[,] Result = new RGBPixel[Height,Width];
            double[,] A = new double[2, 2];
            Rmax = new RGBPixel(0, 0, 0);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    //red value
                    A[0, 0] = Ix2[i, j].red;
                    A[0, 1] = IxIy[i, j].red;
                    A[1, 0] = IxIy[i, j].red;
                    A[1, 1] = Iy2[i, j].red;
                    double detA = Accord.Math.Matrix.Determinant(A);
                    double tracA=Accord.Math.Matrix.Trace(A);
                    Result[i, j].red = (byte)(detA-0.01*(tracA*tracA));
                    if (Result[i, j].red > Rmax.red)
                        Rmax.red = Result[i, j].red; 
                    //green value
                    A[0, 0] = Ix2[i, j].green;
                    A[0, 1] = IxIy[i, j].green;
                    A[1, 0] = IxIy[i, j].green;
                    A[1, 1] = Iy2[i, j].green;
                     detA = Accord.Math.Matrix.Determinant(A);
                    tracA = Accord.Math.Matrix.Trace(A);
                    Result[i, j].green = (byte)(detA - 0.01 * (tracA * tracA));
                    if (Result[i, j].green > Rmax.green)
                        Rmax.green = Result[i, j].green; 
                    //blue value
                    A[0, 0] = Ix2[i, j].blue;
                    A[0, 1] = IxIy[i, j].blue ;
                    A[1, 0] = IxIy[i, j].blue;
                    A[1, 1] = Iy2[i, j].blue;
                    detA = Accord.Math.Matrix.Determinant(A);
                    tracA = Accord.Math.Matrix.Trace(A);
                    Result[i, j].blue = (byte)(detA - 0.01 * (tracA * tracA));
                    if (Result[i, j].blue > Rmax.blue)
                        Rmax.blue = Result[i, j].blue; 

                }
            }
            return Result;
        }
        private  static RGBPixel[,] CalculateRresults(RGBPixel[,] R,RGBPixel Rmax ,out int count) 
        {
            count = 0;
            int Height = ImageOperations.GetHeight(R);
            int Width = ImageOperations.GetWidth(R);
            RGBPixel[,] Result = new RGBPixel[Height,Width];
              for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    Result[i, j] = new RGBPixel(0, 0, 0);
            for (int i = 1; i < Height-1; i++)
            {
                for (int j = 1; j < Width-1; j++)
                {
                    Result[i, j] = new RGBPixel(0, 0, 0);
                    if (R[i,j].red > 0.1*Rmax.red && R[i,j].red > R[i-1,j-1].red && R[i,j].red > R[i-1,j].red && R[i,j].red > R[i-1,j+1].red && R[i,j].red > R[i,j-1].red && R[i,j].red > R[i,j+1].red && R[i,j].red > R[i+1,j-1].red && R[i,j].red > R[i+1,j].red && R[i,j].red > R[i+1,j+1].red)
                    {
                        Result[i, j].red = 1;
                    }
                    if (R[i, j].green > 0.1 * Rmax.green && R[i, j].green > R[i - 1, j - 1].green && R[i, j].green > R[i - 1, j].green && R[i, j].green > R[i - 1, j + 1].green && R[i, j].green > R[i, j - 1].green && R[i, j].green > R[i, j + 1].green && R[i, j].green > R[i + 1, j - 1].green && R[i, j].green > R[i + 1, j].green && R[i, j].green > R[i + 1, j + 1].green)
                    {
                        Result[i, j].green = 1;
                        count++;
                    }
                    if (R[i,j].blue > 0.1*Rmax.blue && R[i,j].blue > R[i-1,j-1].blue && R[i,j].blue > R[i-1,j].blue && R[i,j].blue > R[i-1,j+1].blue && R[i,j].blue > R[i,j-1].blue && R[i,j].blue > R[i,j+1].blue && R[i,j].blue > R[i+1,j-1].blue && R[i,j].blue > R[i+1,j].blue && R[i,j].blue > R[i+1,j+1].blue)
                    {
                        Result[i, j].blue = 1;
                    }
                }
            }
            return Result;
        }
    }
}
