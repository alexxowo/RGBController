using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Controlador_RGB.Internals
{
    public static class Paths
    {
        /// <summary>
        /// Returns path of presets folder in appData
        /// </summary>
        public static string PresetsDir
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RGB Controller\Presets";
            }
        }

        /// <summary>
        /// Returns full path of file located in AppData.
        /// </summary>
        public static string PresetsFileDir
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RGB Controller\Presets\Presets.json";
            }
        }

        public static string EffectsPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RGB Controller\Effects\";
            }
        }
    }
}
