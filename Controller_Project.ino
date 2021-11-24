#define SW 2
#define joyX A0
#define joyY A1

float xValue, yValue;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(19200);
  pinMode(SW, INPUT_PULLUP);
  pinMode(joyX, INPUT);
  pinMode(joyY, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  xValue = analogRead(joyX);
  yValue = analogRead(joyY);

  xValue = map(xValue, 1, 1024, -500, 500);
  yValue = map(yValue, 1, 1024, -500, 500);
 
  //print the values with to plot or view
  Serial.print(xValue);
  Serial.print("\t");
  Serial.print(yValue);
  Serial.println(!digitalRead(SW));
  delay(50);
}
