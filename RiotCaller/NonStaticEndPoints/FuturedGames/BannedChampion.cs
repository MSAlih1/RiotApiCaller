using Newtonsoft.Json;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;

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

        /// <summary>
        /// smarty property
        /// </summary>
        [JsonIgnore]
        public ChampionData Champion { get; set; }
    }
}