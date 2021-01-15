int PinRed   = 11;
int PinGreen = 10;
int PinBlue  = 9;
int conLed = 2;

int red = 0;
int green = 0;
int blue = 0;
char opcion = 0;
int receivedCmd = 0;

int r, g, b;  // Red, Green and Blue values, saving the values taked from Serial port 

bool connected = false;

bool fade = false;

void initPins(){
	analogWrite(PinRed, 0);
	analogWrite(PinGreen, 0);
	analogWrite(PinBlue, 0);
}

void setup()
{
	Serial.begin(9600);

	pinMode(PinRed, OUTPUT);
	pinMode(PinGreen, OUTPUT);
	pinMode(PinBlue, OUTPUT);
}

void getSerialValues(){
	red = Serial.read();
	green = Serial.read();
	blue = Serial.read();
	opcion = Serial.read();
	//receivedCmd = Serial.read();
}

void loop()
{
	if(Serial.available() >= 5){

		getSerialValues();

		/*if(receivedCmd == 'a' && !connected){
			Serial.println("A");
			connected = true;
			digitalWrite(2, HIGH);
		}*/

		analogWrite(PinRed, red);
		analogWrite(PinGreen, green);
		analogWrite(PinBlue, blue);

		if(opcion == 0x52){
			fade = true;
			Serial.println("activating FADE");
		}
		if(fade){
			FadeEffect(400);
		}
	}
}

void FadeEffect(int FADETIME){
	Serial.println("Starting fade effect...");
	initPins();

	if(opcion == 0x30){
		fade = false;
		initPins();
		return;
	}

	// fade from blue to violet
	for (r = 0; r < 256; r++) { 
		analogWrite(PinRed, r);
		getSerialValues();
		Serial.println(opcion);
		if(opcion == 0x30){
			fade = false;
			initPins();
			return;
		}
		delay(FADETIME);
	} 
	delay(1500);
	// fade from violet to red
	for (b = 255; b > 0; b--) { 
		analogWrite(PinBlue, b);

		if(opcion == 0x30){
			fade = false;
			initPins();
			return;
		}
		delay(FADETIME);
	} 

	delay(1500);
	// fade from red to yellow
	for (g = 0; g < 256; g++) { 
		analogWrite(PinGreen, g);

		if(opcion == '0'){
			fade = false;
			initPins();
			return;
		}

		delay(FADETIME);
	} 
		delay(1500);
		// fade from yellow to green
	for (r = 255; r > 0; r--) { 
		analogWrite(PinRed, r);

		if(opcion == 0x30){
			fade = false;
			initPins();
			return;
		}
		delay(FADETIME);
	} 
	delay(1500);
	// fade from green to teal
	for (b = 0; b < 255; b++) { 
		analogWrite(PinBlue, b);
		if(opcion == 0x30){
			fade = false;
			initPins();
			return;
		}
		delay(FADETIME);
	} 
	delay(1500);
	// fade from teal to blue
	for (g = 255; g > 0; g--) { 
		analogWrite(PinGreen, g);

		if(opcion == 0x30){
			fade = false;
			initPins();
			return;
		}
		delay(FADETIME);
	}

	Serial.println("Stoping effect");
	delay(1000);
}
