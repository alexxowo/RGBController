using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Controlador_RGB.Internals
{
    // Character a = 0x61
    public class ArduinoDriverDetect
    {
        public static string arduinoPort()
        {
            bool found = false;
            string portname = string.Empty;
            SerialPort arduinoPortCom = new SerialPort();
            arduinoPortCom.BaudRate = 9600;
            arduinoPortCom.Parity = Parity.None;
            arduinoPortCom.StopBits = StopBits.One;

            for (int i = 0; i < 2; i++)
            {
                if (found)
                    break;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Intentando conectar... Intento:{i}");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var port in SerialPort.GetPortNames())
                {
                    try
                    {
                        arduinoPortCom.PortName = port;

                        arduinoPortCom.Open();
                        arduinoPortCom.Write(new byte[] { 0,0,0,0, 0x61 }, 0, 5);

                        arduinoPortCom.ReadTimeout = 500; // 500ms to read serial port
                        string arduinoResponse = arduinoPortCom.ReadLine();

                        if (arduinoResponse.Substring(0, 1) == "A")
                        {
                            portname = port;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"El puerto del Arduino es: {port}");
                            Console.ForegroundColor = ConsoleColor.White;
                            arduinoPortCom.Close();
                            found = true;
                            break;
                        }

                    }
                    catch (TimeoutException te)
                    {
                        arduinoPortCom.Close();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Error al conectar al puerto {port}");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Error. No se puede conectar.\n{ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }

            }
            if (found)
                return portname;
            else
                return string.Empty;

        }
    }
}
