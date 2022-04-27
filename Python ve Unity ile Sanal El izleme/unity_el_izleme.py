#import cvzone
from cvzone.HandTrackingModule import HandDetector
import cv2
#from cvzone.ColorModule import ColorFinder
import socket

cap = cv2.VideoCapture(0)
cap.set(3, 1280)
cap.set(4, 720)
success, img = cap.read()
h, w, _ = img.shape

# myColorFinder = ColorFinder(False)
# hsvVals = {'hmin': 58, 'smin': 53, 'vmin': 126, 'hmax': 149, 'smax': 105, 'vmax': 255}

detector = HandDetector(maxHands=1,detectionCon=0.8)

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
serverAddressPort = ("127.0.0.1", 5053)

while True:
    # Get image frame
    success, img = cap.read()

    # imgColor, mask = myColorFinder.update(img, hsvVals)
    # imgContour, contours = cvzone.findContours(img, mask)

    # if contours:
    #     data = int(contours[0]['area'])
    #     print(data)

    # Find the hand and its landmarks
    hands, img = detector.findHands(img)  # with draw
    # hands = detector.findHands(img, draw=False)  # without draw
    data = []

    if hands:
        # Hand 1
        hand = hands[0]
        lmList = hand["lmList"]  # List of 21 Landmark points
        for lm in lmList:
            #print(lm[0],lm[1])
            data.extend([lm[0], h - lm[1], 0])
            # data.extend([lm[0], h - lm[1], lm[2]])

        sock.sendto(str.encode(str(data)), serverAddressPort)

    # Display
    img = cv2.resize(img, (0, 0), None, 0.5, 0.5)
    cv2.imshow("Image", img)
    cv2.waitKey(1)
