using RestSharp;
using ShowdownTeamRando.Models;
using System.Text.Json.Nodes;

namespace ShowdownTeamRando
{
    public static class RandomizationHelper
    {
        private const string API_CALL_FILENAME = "API_CALL.json";
        private const string API_URL = "https://api.random.org/json-rpc/4/invoke";

        private static int id = 1;

        public static async Task<RandomizationResult> RandomizeCategory(Category category)
        {
            var restsharp = new RestClient();
            var upcomingTeams = new Queue<Team>();

            string apiCall = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), API_CALL_FILENAME));

            int n = Math.Min(10, category.Teams.Count);
            int max = category.Teams.Count - 1;

            apiCall = apiCall.Replace("%n%", n.ToString());
            apiCall = apiCall.Replace("%max%", max.ToString());
            apiCall = apiCall.Replace("%id%", id.ToString());

            var restRequest = new RestRequest(API_URL);
            restRequest.AddJsonBody(apiCall);

            var response = await restsharp.PostAsync(restRequest);

            if (response.IsSuccessful)
            {
                var responseJson = JsonObject.Parse(response.Content);

                var array = responseJson["result"]["random"]["data"].AsArray();

                foreach (var item in array)
                {
                    var team = category.Teams[item.GetValue<int>()];
                    upcomingTeams.Enqueue(team);
                }

                return new RandomizationResult()
                {
                    Category = category,
                    UpcomingTeams = upcomingTeams,
                    CurrentTeam = upcomingTeams.Dequeue()
                };
            }
            else
                return null;
        }
    }
}
