using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowdownTeamRando.Models
{
    public class Configs
    {
        public string? ShowdownDesktopFileLocation { get; set; }
        public bool ImportFolderOnStartup { get; set; }

        public bool UseGameModes { get; set; } = false;

        public List<string> IgnoredGameModes { get; set; } = new List<string>(Constants.DefaultIgnoredGameModes);
        public List<string> IgnoredFolders { get; set; } = new List<string>(Constants.DefaultIgnoredFolders);
        public List<string> IgnoredTeams { get; set; } = new List<string>();

        public Dictionary<string, TeamFolder> TeamFolders { get; set; } = new Dictionary<string, TeamFolder>();
        public Dictionary<string, GameMode> GameModes { get; set; } = new Dictionary<string, GameMode>();
    }
}
