using Newtonsoft.Json;
using RiotCaller.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.Classes.Team
{

    public class Team
    {
        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("secondLastJoinDate")]
        public DateTime SecondLastJoinDate { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("lastJoinDate")]
        public DateTime LastJoinDate { get; set; }

        [JsonProperty("fullId")]
        public string FullId { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("lastJoinedRankedTeamQueueDate")]
        public DateTime LastJoinedRankedTeamQueueDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("teamStatDetails")]
        public List<TeamStatDetail> TeamStatDetails { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("thirdLastJoinDate")]
        public DateTime ThirdLastJoinDate { get; set; }
        
        [JsonProperty("roster")]
        public Roster Roster { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("modifyDate")]
        public DateTime ModifyDate { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("createDate")]
        public DateTime CreateDate { get; set; }
    }

    public class TeamStatDetail
    {
        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }
    }

    public class MemberList
    {

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("joinDate")]
        public DateTime JoinDate { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("inviteDate")]
        public DateTime İnviteDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("playerId")]
        public int PlayerId { get; set; }
    }

    public class Roster
    {
        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty("memberList")]
        public List<MemberList> MemberList { get; set; }
    }
}
