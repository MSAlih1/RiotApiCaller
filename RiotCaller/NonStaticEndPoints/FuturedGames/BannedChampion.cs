using Newtonsoft.Json;
using RiotCaller.Enums;

namespace RiotCaller.EndPoints.FuturedGames
{
    public class BannedChampion
    {
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public team TeamId { get; set; }
    }
}