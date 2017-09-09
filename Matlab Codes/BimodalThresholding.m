function BimodalThresholding()
Img = imread('1.jpg');
 Img = im2bw(Img);
%figure,imshow(Img);
%figure,imhist(Img);
Tcurr = 20;
Tprev = 1;
while(abs(Tcurr-Tprev)>0.1)
    Tprev = Tcurr;
    MEAN1 = mymean(Img,0,Tcurr);
    MEAN2 = mymean(Img,Tcurr,255);
    Tcurr = (MEAN1+MEAN2)/2;
    %figure,imshow(coins)
end
res =roicolor(Img,Tcurr,255);
figure,imshow(res);
end

function [val] = mymean(img,low ,up)
total = size(img);
sizex = total(1);
sizey = total(2);
sum = 0;
count = 1;
for i=1:sizex
    for j=1:sizey
        if (img(i,j)>=low) && (img(i,j) <= up)
            count = count+1;
            sum=sum + double(img(i,j));       
        end
    end
end
val = sum/count;
end
