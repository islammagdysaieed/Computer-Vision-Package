    I = imread('coins.png');
    I = im2bw(I);
    L = bwlabel(I);
    X = regionprops(L);
    imshow(I);
    hold on;
     
    meanRadius = 0;
    for i = 1:length(X)
        rad = X(i).BoundingBox(3);
        rad = rad / 2;
        meanRadius = meanRadius + rad;
    end
    meanRadius = meanRadius / length(X);
    for i = 1:length(X)
        x = X(i).Centroid(1);
        y = X(i).Centroid(2);
    end
    [centers, radii] =  imfindcircles(I, meanRadius);