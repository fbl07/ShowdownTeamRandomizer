﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowdownTeamRando
{
    public static class Constants
    {
        public static readonly string[] DefaultIgnoredGameModes = new string[]
        {
            "gen1ou",
            "gen2ou",
            "gen3doublesou",
            "gen4doublesou",
            "gen9vgc2024regh",
            "gen9doublesou-box"
        };

        public static readonly string[] DefaultIgnoredFolders = new string[] {
            ".git"
        };

        public static readonly Dictionary<string, string> GameModes = new Dictionary<string, string>()
        {
            { "gen9nationaldexdoubles", "National Dex Doubles" },
            { "gen9cap", "CAP" },
            { "gen9doublesou", "Doubles OU" },
            { "gen9doubleslc", "Little Cup" },
            { "gen9nationaldexdoublesubers", "National Dex Ubers" },
        };
    }
}
