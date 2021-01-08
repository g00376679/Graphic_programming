import cv2
import numpy as np
from matplotlib import pyplot as plt
#import stuff on the top

#import image.
ImgIN = cv2.imread('GMIT1.jpg',)
print(ImgIN)
cv2.imshow('GMIT1.jpg',ImgIN)

# convert grayimge 
plt.subplot(2,3,1),plt.imshow(cv2.cvtColor(ImgIN, cv2.COLOR_BGR2RGB),cmap = 'gray')
plt.title('Original'), plt.xticks([]), plt.yticks([])

gray = cv2.cvtColor(ImgIN,cv2.COLOR_BGR2GRAY)
gray = np.float32(gray) 
 
 #here we seting the size
dst = cv2.cornerHarris(gray,2,3,0.04)
threshold = 0.55; #number between 0 and 1

# plot detecting  harris corners  loop through every element in the 2d mtrix-dst and creating circle if image is grater than treshold
for i in range(len(dst)):
    for j in range(len(dst[i])):
        if dst[i][j] > (threshold*dst.max()):
            cv2.circle(ImgIN,(j,i),3,(255,255,0),-1)

plt.subplot(2,3,2),plt.imshow(dst,cmap = 'gray')
plt.title('Image 2'), plt.xticks([]), plt.yticks([])

plt.subplot(2,3,3),plt.imshow(cv2.cvtColor(ImgIN, cv2.COLOR_BGR2RGB),cmap = 'gray')
plt.title('Image 3'), plt.xticks([]), plt.yticks([])


imgShiTomasi = cv2.goodFeaturesToTrack(gray,50,0.01,10)
imgShiTomasi = np.int0(imgShiTomasi) 
for i in imgShiTomasi:
    x,y = i.ravel()
    cv2.circle(gray,(x,y),3,(255,255,0),-1)

plt.subplot(2,3,4),plt.imshow(gray,cmap = 'gray')
plt.title('Image 4'), plt.xticks([]), plt.yticks([])

orb = cv2.ORB_create()
kp = orb.detect(ImgIN,None)
kp, des = orb.compute(ImgIN, kp)
img2 = cv2.drawKeypoints(ImgIN, kp, None, color=(0,255,0), flags=0)

plt.subplot(2,3,5),plt.imshow(img2,cmap = 'gray')
plt.title('Image 5'), plt.xticks([]), plt.yticks([])

plt.show()
