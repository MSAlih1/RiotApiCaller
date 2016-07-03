using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Game
{
    public class Game
    {
        [JsonProperty("fellowPlayers")]
        public List<FellowPlayer> FellowPlayers { get; set; }

        [JsonProperty("gameType")]
        public gameType GameType { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("ipEarned")]
        public int IpEarned { get; set; }

        [JsonProperty("spell1")]
        public int Spell1 { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("spell2")]
        public int Spell2 { get; set; }

        [JsonProperty("gameMode")]
        public gameMode? GameMode { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("invalid")]
        public bool Invalid { get; set; }

        [JsonProperty("subType")]
        public subType? SubType { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("createDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }
    }
}