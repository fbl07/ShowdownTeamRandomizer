using ShowdownTeamRando.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowdownTeamRando
{
    public static class RandomizationHelper
    {
        public static async Task<RandomizationResult> RandomizeCategory(Category category)
        {
            await Task.Delay(1000);

            var upcomingTeams = new Queue<Team>();

            for (int i = 0; i < 10; i++)
                upcomingTeams.Enqueue(category.Teams[i]);

            return new RandomizationResult()
            {
                Category = category,
                UpcomingTeams = upcomingTeams,
                CurrentTeam = upcomingTeams.Dequeue()
            };
        }
    }
}
