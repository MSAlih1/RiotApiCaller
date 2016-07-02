using Newtonsoft.Json;
using RiotCaller.Converters;
using System;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Team
{
    public class Team
    {
        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("createDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("fullId")]
        public string FullId { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("lastJoinDate")]
        public DateTime LastJoinDate { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("lastJoinedRankedTeamQueueDate")]
        public DateTime LastJoinedRankedTeamQueueDate { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("modifyDate")]
        public DateTime ModifyDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roster")]
        public Roster Roster { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("secondLastJoinDate")]
        public DateTime SecondLastJoinDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("teamStatDetails")]
        public List<TeamStatDetail> TeamStatDetails { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("thirdLastJoinDate")]
        public DateTime ThirdLastJoinDate { get; set; }
    }
}