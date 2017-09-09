function RegionDetection()
Img = imread('coins.png');
Img = im2bw(Img)
Img = bwlabel(Img);
s = regionprops(Img,'Area','BoundingBox');
figure,imshow(Img);
end