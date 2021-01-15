using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Controlador_RGB.Internals;
using Newtonsoft.Json;

namespace Controlador_RGB
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreatePresetsFile();

            var exist = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count() > 1;

            if (!exist)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Principal());
            }
            else
            {
                MessageBox.Show("Ya esta corriendo el programa en segundo plano.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private static void CreatePresetsFile()
        {
            // to see directories, view the PATHS.cs file.
            // if Directory in AppData does exist, create it.
            if (!Directory.Exists(Paths.PresetsDir))
            {
                Directory.CreateDirectory(Paths.PresetsDir);
            }

            // you can use List<T> or Dictionary<T, T>
            // If file "Presets.json" does exist, create it.
            if (!File.Exists(Paths.PresetsFileDir))
            {
                List<Presets> PresetsList = new List<Presets>() {
                    new Presets("Default", 0, 0, 0)
                };

                //Dictionary<string, Presets> PresetsList = new Dictionary<string, Presets>()
                //{
                //    { "Default", new Presets("Default", 0, 0 ,0) }
                //};

                SerializerControls.Serializer(PresetsList);

            }
        }

    }
}
