using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowdownTeamRando.Models
{
    public class ImportResult
    {
        public Dictionary<string, TeamFolder> Folders { get; set; } = new Dictionary<string, TeamFolder>();
        public Dictionary<string, GameMode> GameModes { get; set; } = new Dictionary<string, GameMode>();
    }
}
