#include<Servo.h>

Servo serX;
Servo serY;
Servo pumpServo;

String serialData;

void setup() {

  serX.attach(11);
  serY.attach(10);
  pumpServo.attach(9);
  serX.write(90);
  serY.write(90);
  pumpServo.write(180);
  Serial.begin(9600);
  Serial.setTimeout(10);
}

void loop() {
//servo test loop
/*
  for (int pos = 0; pos <= 180; pos += 1)
  {
    serX.write(pos);
    //serY.write(180 - pos);
    //serYb.write(pos);
    delay(15);  
  }

  
  
  delay(100);

  for (int pos = 180; pos >= 0; pos -= 1)
  {
    serX.write(pos);
    //serY.write(180 - pos);
    //serYb.write(pos);
    delay(15);  
  }
  delay(5000);
  */
}

void(* reset)(void) = 0;

void serialEvent() {
  serialData = Serial.readString();
  
  if (serialData.indexOf("X") == 0)
  {
    serX.write(180 - (parseDataX(serialData)));
    serY.write(parseDataY(serialData));
  }
  else if (serialData.indexOf("f") == 0)
  {
    pumpServo.write(115);
    delay(1000);
    pumpServo.write(180);
    delay(250);
  }
  else if(serialData.indexOf("r") == 0)
  {
    reset();
  }

  else if(serialData.indexOf("s") == 0)
  {
    serY.write(150);
    delay(3000);
    serY.write(90);
  }

  else if(serialData.indexOf("l") == 0)
  {
    serY.write(90);
    serX.write(45);
    
  }
  
  //serYb.write(parseDataY(serialData));
}

int parseDataX(String data){
  data.remove(data.indexOf("Y"));
  data.remove(data.indexOf("X"), 1);
  return data.toInt();
}

int parseDataY(String data){
  data.remove(0,data.indexOf("Y") + 1);
  return data.toInt();
}
