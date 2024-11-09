using ShowdownTeamRando.Models;
using System.Text.RegularExpressions;

namespace ShowdownTeamRando
{
    public static class ImportHelper
    {
        public static ImportResult ImportFromShowdownDesktop(Configs config)
        {
            var result = new ImportResult();

            if (config.ShowdownDesktopFileLocation == null)
                throw new ArgumentNullException("folderLocation");

            if (!Directory.Exists(config.ShowdownDesktopFileLocation))
                throw new InvalidOperationException("Folder specified for import does not exist.");

            foreach (var folder in Directory.EnumerateDirectories(config.ShowdownDesktopFileLocation))
            {
                if (config.IgnoredFolders.Contains(Path.GetFileName(folder)))
                    continue;
                
                var folderObject = new TeamFolder() { Name = Path.GetFileName(folder) };

                foreach (var team in Directory.EnumerateFiles(folder))
                {
                    var filename = Path.GetFileNameWithoutExtension(team);

                    var regex = new Regex(@"\[([\w-]+)\] (.+)");

                    var matches = regex.Match(filename);

                    string gameMode = matches.Groups[1].Value;
                    string teamName = matches.Groups[2].Value;

                    if (config.IgnoredGameModes.Contains(gameMode))
                        continue;

                    string displayGameMode;

                    if (!Constants.GameModes.ContainsKey(gameMode))
                        displayGameMode = gameMode;
                    else
                        displayGameMode = Constants.GameModes[gameMode];

                    if (config.IgnoredTeams.Contains(teamName))
                        continue;

                    var teamObject = new Team()
                    {
                        Name = teamName,
                        Folder = folderObject.Name,
                        GameMode = displayGameMode,
                    };

                    folderObject.Teams.Add(teamObject);

                    if (!result.GameModes.ContainsKey(teamObject.GameMode))
                        result.GameModes.Add(teamObject.GameMode, new GameMode()
                        {
                            Name = teamObject.GameMode
                        });
                        
                    result.GameModes[teamObject.GameMode].Teams.Add(teamObject);
                }

                if (folderObject.Teams.Any())
                    result.Folders.Add(folderObject.Name, folderObject);
            }

            return result;
        }

        public static ImportResult ImportFromPaste(Configs config, string paste)
        {
            var result = new ImportResult();

            var regex = new Regex(@"=== \[([\w-]+)\] (.+)\/(.+) ===");

            foreach (Match teamMatch in regex.Matches(paste))
            {
                var gameMode = teamMatch.Groups[1].Value;

                if (config.IgnoredGameModes.Contains(gameMode))
                    continue;

                string displayGameMode;

                if (!Constants.GameModes.ContainsKey(gameMode))
                    displayGameMode = gameMode;
                else
                    displayGameMode = Constants.GameModes[gameMode];

                var newTeam = new Team()
                {
                    Name = teamMatch.Groups[3].Value,
                    Folder = teamMatch.Groups[2].Value,
                    GameMode = displayGameMode,
                };

                if (config.IgnoredFolders.Contains(newTeam.Folder))
                    continue;

                if (config.IgnoredTeams.Contains(newTeam.Name))
                    continue;

                if (!result.Folders.ContainsKey(newTeam.Folder))
                    result.Folders.Add(newTeam.Folder, new TeamFolder()
                    {
                        Name = newTeam.Folder
                    });

                result.Folders[newTeam.Folder].Teams.Add(newTeam);

                if (!result.GameModes.ContainsKey(newTeam.GameMode))
                    result.GameModes.Add(newTeam.GameMode, new GameMode()
                    {
                        Name = newTeam.GameMode
                    });

                result.GameModes[newTeam.GameMode].Teams.Add(newTeam);
            }

            return result;
        }
    }
}
