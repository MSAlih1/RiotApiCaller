using Newtonsoft.Json;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints
{
    public class MiniSeries
    {
        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }

    public class Entry
    {
        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        [JsonProperty("isFreshBlood")]
        public bool IsFreshBlood { get; set; }

        [JsonProperty("isHotStreak")]
        public bool IsHotStreak { get; set; }

        [JsonProperty("division")]
        public division Division { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("isVeteran")]
        public bool IsVeteran { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("miniSeries")]
        public MiniSeries MiniSeries { get; set; }
    }

    public class League
    {
        [JsonProperty("queue")]
        public queue Queue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }

        [JsonProperty("entries")]
        public List<Entry> Entries { get; set; }

        [JsonProperty("tier")]
        public Tier Tier { get; set; }
    }
}
