using Newtonsoft.Json;
using RiotCaller.Converters;
using System;

namespace RiotCaller.EndPoints.ChampionMastery
{
    public class ChampionMastery
    {
        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }

        [JsonProperty("playerId")]
        public long PlayerId { get; set; }

        [JsonProperty("championPointsUntilNextLevel")]
        public int ChampionPointsUntilNextLevel { get; set; }

        [JsonProperty("chestGranted")]
        public bool ChestGranted { get; set; }

        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }

        [JsonProperty("tokensEarned")]
        public int TokensEarned { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("championPointsSinceLastLevel")]
        public int ChampionPointsSinceLastLevel { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("lastPlayTime")]
        public DateTime LastPlayTime { get; set; }
    }
}