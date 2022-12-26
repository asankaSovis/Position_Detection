#define LED_ONE 13
#define LED_TWO 12
#define LED_THREE 11
#define LED_FOUR 10
#define MAX_INTENSITY 255

byte OneID = 0x55;
byte TwoID = 0xAA;
byte ThreeID = 0x5A;
byte FourID = 0xA5;

void setup( ){
  pinMode ( LED_ONE, OUTPUT);
  pinMode ( LED_TWO, OUTPUT);
  pinMode ( LED_THREE, OUTPUT);
  pinMode ( LED_FOUR, OUTPUT);
}

void loop() {
  driveLED(LED_ONE, OneID);
  driveLED(LED_TWO, TwoID);
  driveLED(LED_THREE, ThreeID);
  driveLED(LED_FOUR, FourID);
}

void driveLED(int LED, byte LEDID) {
  analogWrite(LED, MAX_INTENSITY);
  delay(1000);
  analogWrite(LED, 0);
  delay(100);
  for (int i = 0; i < 8; i++) {
    if (bitRead(LEDID, i)) {
      analogWrite(LED, MAX_INTENSITY);
    } else {
      analogWrite(LED, 0);
    }
    delay (100);
  }
  analogWrite(LED, MAX_INTENSITY);
  delay(1000);
  analogWrite(LED, 0);
}
