using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RiotCaller.EndPoints.FuturedGames
{
    public class GameList
    {
        [JsonProperty("gameLength")]
        public int GameLength { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("bannedChampions")]
        public List<BannedChampion> BannedChampions { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("observers")]
        public Observers Observers { get; set; }

        [JsonProperty("gameQueueConfigId")]
        public int GameQueueConfigId { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("gameStartTime")]
        public DateTime GameStartTime { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("platformId")]
        public Platform PlatformId { get; set; }
    }
}
