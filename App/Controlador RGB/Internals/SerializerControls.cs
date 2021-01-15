using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Controlador_RGB.Internals
{
    public static class SerializerControls
    {
        /// <summary>
        /// Serializer method. This method verify if the directory exist.
        /// </summary>
        /// <param name="obj">object to serialize</param>
        public static void Serializer(object obj)
        {
            if (!Directory.Exists(Paths.PresetsDir)){
                Directory.CreateDirectory(Paths.PresetsDir);
            }

            using (StreamWriter file = File.CreateText(Paths.PresetsFileDir))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(file, obj);
            }

        }

        /// <summary>
        /// Method to add Preset to file.
        /// </summary>
        /// <param name="valueName">Name of preset</param>
        /// <param name="obj">Values of presets (Type of Presets)</param>
        public static void AddPresetDic(string valueName, Presets obj)
        {
            Dictionary<string, Presets> presets = DeserializeDictionary<Presets>();

            presets.Add(valueName, obj);

            Serializer(presets);

        }

        /// <summary>
        /// Method to add preset to file, using generic list.
        /// </summary>
        /// <param name="valueName"></param>
        /// <param name="obj"></param>
        public static void AddPreset(string valueName, Presets obj)
        {
            List<Presets> preset = Deserialize<Presets>();

            PresetNameForm PresetName = new PresetNameForm();

            obj.Name = valueName;

            preset.Add(obj);

            Serializer(preset);
        }

        /// <summary>
        /// Method to deserialize Lists
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns></returns>
        public static List<T> Deserialize<T>()
        {
            List<T> presetFile = new List<T>();

            presetFile = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(Paths.PresetsFileDir));

            return presetFile;

        }

        /// <summary>
        /// Deserializer dictionary
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns></returns>
        public static Dictionary<string, T> DeserializeDictionary<T>()
        {
            Dictionary<string, T> presetFile = new Dictionary<string, T>();

            presetFile = JsonConvert.DeserializeObject<Dictionary<string, T>>(File.ReadAllText(Paths.PresetsFileDir));

            return presetFile;

        }

    }
}
