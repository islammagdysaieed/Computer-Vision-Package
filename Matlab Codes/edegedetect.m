
function EdegeDetection ()
Img = imread('onion.png');
Img = im2bw(Img);
SE = strel('square',5);
eroded = imerode(Img,SE);
dialated = imdilate(Img,SE)
resultbyErosion = Img-eroded;
resultbyDialation = dialated-Img;
figure,imshow(resultbyDialation);
figure,imshow(resultbyErosion);
end