using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Match
{
    public class MatchDetailTeam
    {
        [JsonProperty("bans")]
        public List<Ban> Bans { get; set; }

        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        [JsonProperty("winner")]
        public bool Winner { get; set; }

        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }

        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        [JsonProperty("dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }

        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }

        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }
    }
}