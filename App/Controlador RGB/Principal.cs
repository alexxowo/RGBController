using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using Controlador_RGB.Internals;
using System.Collections.Generic;

namespace Controlador_RGB
{
    public partial class Principal : Form
    {
        SerialPort ArduinoPort;
        bool Conexion = false;

        Color colorValues;
        int R, G, B;

        byte defaultValue = 0x30;
        Color defaultColor = Color.FromArgb(0, 0, 0);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        List<Presets> PresetsList = SerializerControls.Deserialize<Presets>();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Principal()
        {
            InitializeComponent();

            getAllPresets();
            getComPorts();
        }

        #region Arduino_process

        // set effects
        private void SetEffect(byte effect)
        {
            ArduinoPort.Write(new[] { defaultColor.R, defaultColor.G, defaultColor.B, effect }, 0, 4);
        }

        // set colors to serialPort
        private void SetColor(Color color)
        {
            ArduinoPort.Write(new[] { color.R, color.G, color.B, defaultValue }, 0, 4);
        }

        // Conexion al arduino.
        // Connection to Arduino.
        private void ConnectArduino()
        {
            string portComSelected = ComPorts.GetItemText(ComPorts.SelectedItem);
            ArduinoPort = new SerialPort(portComSelected, 9600, Parity.None, 8, StopBits.One); // Initialize serial port.

            try
            {
                Conexion = true;  // Establecer la conexion en TRUE para validar. || This value validate if arduino and APP are binded.
                ArduinoPort.Open(); 
                // Estilos que cambian al modificar la conexion.
                // EN: Styles for form button and label.
                Connection_btn.Text = "CLOSE";
                Connection_btn.BackColor = Color.Crimson;
                StateLevel_lb.Text = "CONNECTED";
                StateLevel_lb.ForeColor = Color.FromArgb(6, 214, 160);

                // ES: Activa los controles
                // EN: Enable the controls
                Red_Controller.Enabled = true;
                Green_Controller.Enabled = true;
                Blue_Controller.Enabled = true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "EXCEPTION.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Desconectar el arduino.
        private void DisconnectArduino()
        {
            Conexion = false; // Establece la validacion en FALSE.
            ArduinoPort.Close(); // Cierra la conexion al puerto seleccionado.

            // Estilos que cambian al modificar la conexion.
            // EN: Styles for form button and label.
            Connection_btn.Text = "OPEN";
            Connection_btn.BackColor = Color.FromArgb(6, 214, 160);
            StateLevel_lb.Text = "DISCONNECTED";
            StateLevel_lb.ForeColor = Color.Crimson;

            // Desactiva los controles
            // disable the controls
            Red_Controller.Enabled = false;
            Green_Controller.Enabled = false;
            Blue_Controller.Enabled = false;
        }

        #endregion


        // ESTABLECER CONEXION ENTRE ARDUINO Y APP.
        // Establish connection between arduino and C # app
        private void Connection_Btn_Click(object sender, EventArgs e)
        {
            if (!Conexion)
                ConnectArduino();
            else
                DisconnectArduino();
        }

        // button to apply Effects
        // Save colors
        private void SaveColorBtn_Click(object sender, EventArgs e)
        {
            PresetNameForm Psf = new PresetNameForm();

            Psf.ShowDialog();

            if(Psf.DialogResult == DialogResult.OK)
            {
                Presets preset = new Presets(Psf.PresetNameBox.Text, R, G, B);
                SerializerControls.AddPreset(Psf.PresetNameBox.Text, preset);
                MessageBox.Show("Preset " + Psf.PresetNameBox.Text + " has been created.", "PRESETS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PresetsColor.Items.Clear();
                getAllPresets();
            }
        }

        // event to change and send with serial port the preset config
        private void PresetsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Conexion)
            {
                try
                {
                    string selectedPreset = PresetsColor.GetItemText(PresetsColor.SelectedItem);
                    int selectedPresetId = PresetsColor.SelectedIndex;
                    bool validate = PresetsList.Exists(x => x.Name.Equals(selectedPreset));

                    if (validate)
                    {
                        int R = PresetsList[selectedPresetId].R;
                        int G = PresetsList[selectedPresetId].G;
                        int B = PresetsList[selectedPresetId].B;

                        Red_Controller.Value = R;
                        Green_Controller.Value = G;
                        Blue_Controller.Value = B;

                        Color colorPreset = Color.FromArgb(R, G, B);

                        ColorView.BackColor = Color.FromArgb(R, G, B);

                        UpdatePreview();

                        SetColor(colorPreset);
                        MessageBox.Show(selectedPreset);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has ocurred, Contact with the developer.\nError: "+ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //else
            //{
            //    MessageBox.Show("Error. Arduino has no connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        #region BuildMethods

        // obtain all Comports
        private void getComPorts()
        {
            foreach (string port in SerialPort.GetPortNames())
            {
                ComPorts.Items.Add(port);
                if (port != null)
                {
                    ComPorts.SelectedItem = port;
                }
            }
        }

        // Obtener valores de los controles
        // Obtain values from controllers.
        private void getValues(object sender, EventArgs e)
        {
            R = (int)Red_Controller.Value; // Takes Red data
            G = (int)Green_Controller.Value; // Takes Green Data
            B = (int)Blue_Controller.Value; // Takes Blue Data
            UpdatePreview(); // Actualiza Preview

            redLabel.Text = R.ToString();
            GreenLabel.Text = G.ToString();
            BlueLabel.Text = B.ToString();

            // Escribo valores a Arduino mediante serialPort.
            // Write values to arduino with serialPort.
            colorValues = Color.FromArgb(R, G, B);
            SetColor(colorValues);
        }

        // get all presets in the presets.json file.
        private void getAllPresets()
        {
            //Dictionary<string, Presets> PresetsList = SerializerControls.DeserializeDictionary<Presets>();
            List<Presets> PresetsList = SerializerControls.Deserialize<Presets>();

            foreach (var Preset in PresetsList)
            {
                PresetsColor.Items.Add(Preset.Name);
            }

            if (PresetsList[0] != null)
            {
                PresetsColor.SelectedItem = PresetsList[0].Name;
            }

        }

        #endregion

        #region Window_properties

        // update preview
        void UpdatePreview()
        {
            colorValues = Color.FromArgb(R, G, B);
            ColorView.BackColor = colorValues;
        }

        void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e) { }

        private void Minimize_btn_Click(object sender, EventArgs e) { this.Hide(); }

        // Background Icon
        // Icono de Segundo Plano.
        private void BackgroundIconNot_MouseClick(object sender, MouseEventArgs e) { this.Show(); }

        #endregion
    }
}
