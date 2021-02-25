# FaceDetectionTurret



 # WinForm 


Feeds serial data to an Arduino. Program runs facial recognition using the AForge.NET library and a camera. The camera frame is converted to a bitmap, then a gray scale image, then facial recognition data is given by a Cascade Classifier ("haarcascade_frontalface_alt_tree.xml") which assists in detecting what and where a face is in the image. A box is drawn around the detected face, and the X and Y coordinate values of the center of the box are scaled to reflect the FOV (Field Of View) of the camera. Scaling the coordinate values constricts the movement of the servo motors to the bounds of the camera which in turn allows for accurate positioning of the servos within the ArduinoInterpreter program. Additionally, the WinForm runs .NET voice recognition to control the actuation of the pump servo, communication of serial data, deactivation of voice recognition, and termination of the form. 
 





# ArduinoInterpreter 


Program that runs on an Arduino microcontroller to interpret the serial data send from the WinForm, and control the movement of servo motors. The AruinoInterpreter program parses serial data sent from WinForm and carrys out functions determined by the data that was sent. 
