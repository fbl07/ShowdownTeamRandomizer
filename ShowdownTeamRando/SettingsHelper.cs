using ShowdownTeamRando.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShowdownTeamRando
{
    public static class SettingsHelper
    {
        const string SETTING_FILENAME = "config.json";

        public static void SaveSettings(Configs configs)
        {
            var settingsFilename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), SETTING_FILENAME);

            string settingJson = JsonSerializer.Serialize(configs);
            File.WriteAllText(settingsFilename, settingJson);
        }

        public static Configs LoadSettings()
        {
            var settingsFilename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), SETTING_FILENAME);

            if (File.Exists(settingsFilename))
            {
                string settingsJson = File.ReadAllText(settingsFilename);
                Configs readSettings = JsonSerializer.Deserialize<Configs>(settingsJson);
                return readSettings;
            }
            else
                return null;
        }
    }
}
