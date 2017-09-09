function NoiseRemoval()
Img = imread('AT3_1m4_01.tif');
Img = im2bw(Img);
SE = strel('disk',1);
eroded = imerode(Img,SE);
dialated = imdilate(eroded,SE)
figure,imshow(Img);
figure,imshow(dialated);
end