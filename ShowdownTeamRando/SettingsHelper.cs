using ShowdownTeamRando.Models;
using System.Text.Json;

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

                if (readSettings.Version == null)
                    readSettings.Version = "1.2.0";

                if (readSettings.Version == "1.2.0")
                {
                    Migration_1_2_0__1_3_0(readSettings);
                    SaveSettings(readSettings);
                }

                return readSettings;
            }
            else
                return null;
        }

        private static void Migration_1_2_0__1_3_0(Configs configs)
        {
            if (!configs.IgnoredGameModes.Contains("gen9nationaldexdoubles-box"))
                configs.IgnoredGameModes.Add("gen9nationaldexdoubles-box");

            if (!configs.IgnoredGameModes.Contains("gen2stadiumou"))
                configs.IgnoredGameModes.Add("gen2stadiumou");

            if (!configs.IgnoredGameModes.Contains("gen1ubers"))
                configs.IgnoredGameModes.Add("gen1ubers");

            configs.Version = "1.3.0";
        }

    }
}
