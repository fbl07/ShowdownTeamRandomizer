echo Copying Build's zip file
set projectdir=%1
cd "%projectdir%\bin\Release\net8.0-windows\""
tar.exe -a -cf "%projectdir%..\PokemonShowdownTeamRandomizer.zip" "*"