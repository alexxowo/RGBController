# ❤️💚💙 RGBController ❤️💚💙

## Table of Contents
1. [Operation For Beginners](#OPERATION-FOR-BEGINNERS )
2. [C# APP](#c-app)
3. [Arduino Sketch](#arduino-sketch)

This project works for any type of RGB LED, from simple LED strips to 5mm rgb LEDs.
The regulator circuit can be found in the following <a href="#noUpdated">link</a> and detailed information:

### OPERATION FOR BEGINNERS 

The Arduino that you select for this project (Nano, Uno, mega, etc) sends a PWM signal through its pins 9, 10 and 11. This signal has a voltage level of 5V, but it cannot give large currents (Technical information below), it is necessary to amplify said current or voltage (if necessary).

For the test, 3 IRF34N Mosfets were used. Any MOSFET (whose threshold voltage is below 4V as a minimum) or transistor (that can handle the necessary currents) will be useful for this small project.

[![Esquematico-RGB-Controller.jpg](https://i.postimg.cc/kD32F07y/Esquematico-RGB-Controller.jpg)](https://postimg.cc/zH7DqPbL)

Output current limits:

    * If powered by USB: a total of 500 mA
    * If powered by external source or battery: a total of 500 mA ~ 1 A
    * Individual maximum per I / O pin: 40 mA (recommended not to exceed 20 mA for longer life)

## 👾 C# APP

The app is written using C #, using the 4.5 framework and Windows Form.
Code documentation can be found on the following website.

From the C # program, predefined colors can be saved, these are stored in JSON format in established directories.


### Directories

Inside Internals, there is the Paths.cs file, which establishes the different paths where the configuration files are stored in JSON.

PresetsFile: C:\Users\[USERNAME]\AppData\Roaming\RGB Controller\Presets
EffectsPath: C:\Users\[USERNAME]\AppData\Roaming\RGB Controller\Effects *💣

#### 💣 EffectsPath: It is the effects directory, it has not been fully implemented yet, the future plan is to be able to create custom effects from the app.💣

### Method: arduinoPort () - Auto detect Arduino

The ArduinoDriverDetect.cs file inside the Internals folder contains the method that is responsible for obtaining the COM port where it is connected.

The arduinoPort () method returns a string with the name of that port. Basically what this function does is send a character to the arduino through all the possible COM ports that it detects, if arduino detects it, arduino responds with another character, if both characters that they send correspond with the established ones, it proceeds to send the name of the COM port where the connection was "SUCCESSFUL".

### Presets

There is not much to say, the Presets.CS file inside Internals sets the properties of the RGB channels and the name of the preset. Later this file will work to serialize using JSON.

## 💫 Arduino Sketch

The arduino Sketch is not complex. Simply initialize the serial port with the established baud rate (It must be the same with which the app works). It eventually listens in the buffer for more than 4 bits of data.

As the data arrives, the values of the RGB and the command to execute are obtained.
Upon detecting the command or character selected for the link, it returns another character and establishes the connection.
