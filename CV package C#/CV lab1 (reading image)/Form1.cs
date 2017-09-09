using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_lab1__reading_image_
{ 
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void open_Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                RGBPixel[,] original_bm  = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(original_bm,originalImagePbox);
                InputImageInfo.imgCopy = original_bm;
                originalImagePbox.SizeMode = PictureBoxSizeMode.StretchImage;
                InputImageInfo.GetMinMaxRGBValues(original_bm);
                 MaxGrayTB.Text = InputImageInfo.maxValue.ToString();
                 minGrayTB.Text = InputImageInfo.minValue.ToString();      
                 
            }
        }
        private void Threshold_Click(object sender, EventArgs e)
        {
            double threshold = double.Parse(thresholdTB.Text);
            RGBPixel[,]output =  Contrast.Apply_Threshold(InputImageInfo.imgCopy, threshold);
            ImageOperations.DisplayImage(output, outputImagePbox);
            outputImagePbox.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }
        private void ApplyHistogram_Click(object sender, EventArgs e)
        {
            double B = double.Parse(B_ContrastTB.Text);
            RGBPixel[,] output = Contrast.ContrastStretch(InputImageInfo.imgCopy, B);
            ImageOperations.DisplayImage(output, outputImagePbox);
            outputImagePbox.SizeMode = PictureBoxSizeMode.StretchImage; ;
        }
        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            RGBPixel[,] output = Filter.ApplyFilter(InputImageInfo.imgCopy, Filter.SelectedFilter, Filter.SelectedFilter_KernelSize);
            ImageOperations.DisplayImage(output, outputImagePbox);
            outputImagePbox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadFilterTypesCombo();
        }
        private void loadFilterTypesCombo()
        {
            filterTypeCB.Items.Add(FilterType.Mean);
            filterTypeCB.Items.Add(FilterType.HorizontalSobel);
            filterTypeCB.Items.Add(FilterType.VerticalSobel);
            filterTypeCB.SelectedIndex = 0;
            Filter.SelectedFilter = (FilterType)filterTypeCB.SelectedItem;
            Filter.SelectedFilter_KernelSize = 3;
        }
        private void filterTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((FilterType)filterTypeCB.SelectedItem == FilterType.Mean)
                Filter.SelectedFilter = FilterType.Mean;
            else if ((FilterType)filterTypeCB.SelectedItem == FilterType.HorizontalSobel)
                    Filter.SelectedFilter = FilterType.HorizontalSobel;
            else if ((FilterType)filterTypeCB.SelectedItem == FilterType.VerticalSobel)
                Filter.SelectedFilter = FilterType.VerticalSobel;
        }

        private void HarrisBT_Click(object sender, EventArgs e)
        {
          //Harris.HarrisIscalled = true;
          Harris.featurePoints =  Harris.Harris_2(InputImageInfo.imgCopy);
          RGBPixel[,] output =  DrawFeature(Harris.featurePoints);
          ImageOperations.DisplayImage(output, outputImagePbox);
          outputImagePbox.SizeMode = PictureBoxSizeMode.StretchImage;
          harrisFeatureCountTB.Text = Harris.FeaturePointCount.ToString();
        }

        private RGBPixel[,] DrawFeature(RGBPixel[,] featurePoints)
        {
            int Height = ImageOperations.GetHeight(featurePoints);
            int Width = ImageOperations.GetWidth(featurePoints);
            RGBPixel[,] output = new RGBPixel[Height, Width]; 
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                   output[i,j] = InputImageInfo.imgCopy[i, j];
                    if (featurePoints[i, j].red == 1)
                    {
                        output[i, j] = new RGBPixel(0, 5, 255);
                    }
                }
            }
            return output;
        }

    }
}
