namespace ShowdownTeamRando.Models
{
    public class Category
    {
        public virtual string? Name { get; set; }
        public virtual List<Team> Teams { get; set; } = new List<Team>();

    }
}
