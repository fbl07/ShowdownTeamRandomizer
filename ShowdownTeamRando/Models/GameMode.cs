namespace ShowdownTeamRando.Models
{
    public class GameMode : Category
    {
        public override string? Name { get; set; }

        public override List<Team> Teams { get; set; } = new List<Team>();
    }
}
