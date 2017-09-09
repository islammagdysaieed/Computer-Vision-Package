function ThresholdingByHistogram()
 Img = imread('1.jpg');
 Img = im2bw(Img);
 figure,imshow(Img);
 figure,imhist(Img);
 coins =roicolor(Img,99,255)
 figure,imshow(coins)
end