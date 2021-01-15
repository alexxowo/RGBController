using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Controlador_RGB.Internals
{
    class cEffects
    {

        private static int R, G, B;
        private static byte defaultData = 0x30;
        private static Color color = new Color();

        static public void CustomFade(SerialPort ArduinoPort, Color A, Color B)
        {

            if (ArduinoPort.IsOpen)
            {

                

            }
            else
            {
                MessageBox.Show("Port is not open.", "Serial Port ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

    }
}
