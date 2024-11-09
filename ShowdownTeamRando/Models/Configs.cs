namespace ShowdownTeamRando.Models
{
    public class Configs
    {
        public Configs()
        {
            if (Version == null)
                Version = "1.2.0";
        }

        public string? ShowdownDesktopFileLocation { get; set; }
        public bool ImportFolderOnStartup { get; set; }
        public bool UseGameModes { get; set; } = false;
        public string Version { get; set; }

        public List<string> IgnoredGameModes { get; set; } = new List<string>(Constants.DefaultIgnoredGameModes);
        public List<string> IgnoredFolders { get; set; } = new List<string>(Constants.DefaultIgnoredFolders);
        public List<string> IgnoredTeams { get; set; } = new List<string>();

        public Dictionary<string, TeamFolder> TeamFolders { get; set; } = new Dictionary<string, TeamFolder>();
        public Dictionary<string, GameMode> GameModes { get; set; } = new Dictionary<string, GameMode>();
    }
}
