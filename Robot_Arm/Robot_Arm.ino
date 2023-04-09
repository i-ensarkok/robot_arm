#include <Servo.h>

/* SERVO OBJECTS */
Servo servoB; //Base motor
Servo servoS; //Shoulder motor
Servo servoE; //Elbow motor
Servo servoH; //Hand motor

void setup() {

  Serial.begin(9600); //Arduino baudrate

  /* SERVOS DECLARATIONS*/
  servoB.attach(9); 
  servoS.attach(10); 
  servoE.attach(11); 
  servoH.attach(5); 

  /* ROBOT HAND START POSITION */
  servoB.write(90); 
  servoS.write(90);
  servoE.write(120);
  servoH.write(5);

}

void loop() 
{
  if(Serial.available())      //CONTROLLING SERIAL CONNECTION
    {
     /* SEPERATION SERIAL PORT DATA TO CHANNEL AND ANGLE*/ 
     int channel = Serial.readStringUntil('!').toInt();   //WHICH TRACKBAR MOVE ON DESKTOP APPLICATION
     int angle = Serial.readStringUntil('/').toInt();     //WHAT IS THE VALUE OF TRACKBAR
     
           switch(channel)
           {
            case 1:
              servoB.write(angle);        
              break;
            case 2:
              servoS.write(angle);        
              break;
            case 3:
              servoE.write(angle);
              break;
            case 4:
              servoH.write(angle);
              break;       
           }          
    }              
}
