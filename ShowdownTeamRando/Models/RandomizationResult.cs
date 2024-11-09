namespace ShowdownTeamRando.Models
{
    public class RandomizationResult
    {
        public required Category Category { get; set; }
        public required Team CurrentTeam { get; set; }
        public Queue<Team> UpcomingTeams { get; set; } = new Queue<Team>();
    }
}
