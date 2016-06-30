using Newtonsoft.Json;
using RiotCaller.Attributes;
using System;
using System.Collections.Generic;

namespace RiotCaller.ApiEndPoints
{
    public class MemberList
    {
        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("inviteDate")]
        public DateTime İnviteDate { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("joinDate")]
        public DateTime JoinDate { get; set; }
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Roster
    {
        [JsonProperty("memberList")]
        public List<MemberList> MemberList { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }
    }

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

    public class TeamStatDetail
    {
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}