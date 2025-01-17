﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOS2Randomizer.DataStructures;
using Newtonsoft.Json;

namespace DOS2Randomizer.Util {
    /// <summary>
    /// static class used for (de-)serializing configs
    /// </summary>
    public static class FileIo {

        /// <summary>
        /// Deserialize a config
        /// </summary>
        /// <typeparam name="T">type of config</typeparam>
        /// <param name="fileName">path to file</param>
        /// <returns>deserialized config or null if deserialization failed</returns>
        public static T? ImportConfig<T>(string fileName) where T : class, IConfig {
            T? spells = null;
            try {
                using var file = File.OpenRead(fileName);
                using var reader = new StreamReader(file);
                spells = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
            } catch (JsonException e) {
                MessageBox.Show(String.Format(Resources.ErrorMessages.JsonParseFailed, fileName) + Environment.NewLine +
                                e.Message);
            } catch (FileNotFoundException e) {
                MessageBox.Show(e.Message);
            } catch (IOException exception) {
                MessageBox.Show(String.Format(Resources.ErrorMessages.FileOpenFailed, fileName) +
                                Environment.NewLine + exception.Message);
            } catch (ArgumentException) {
                MessageBox.Show(Resources.ErrorMessages.ImportConfigFailed);
            }

            return spells;
        }

        /// <summary>
        /// Serialize and save a config 
        /// </summary>
        /// <typeparam name="T">Type of config</typeparam>
        /// <param name="config">config to serialize</param>
        /// <param name="fileName">destination file</param>
        public static void SaveConfig<T>(T config, string fileName) where T: IConfig {
            try {
                using var file = File.Open(fileName, FileMode.Create);
                using var writer = new StreamWriter(file);
                var json = JsonConvert.SerializeObject(config);
                writer.Write(json);
                MessageBox.Show(Resources.Messages.SaveSuccessful);
            } catch (IOException exception) {
                MessageBox.Show(Resources.ErrorMessages.SaveError + exception.Message);
            } catch (JsonSerializationException e) {
                MessageBox.Show(Resources.ErrorMessages.JsonSerializeFailed + e.Message);
            }
        }
    }
}
