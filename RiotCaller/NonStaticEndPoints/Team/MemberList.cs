using Newtonsoft.Json;
using RiotCaller.Converters;
using System;

namespace RiotCaller.EndPoints.Team
{
    public class MemberList
    {
        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("inviteDate")]
        public DateTime InviteDate { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("joinDate")]
        public DateTime JoinDate { get; set; }

        [JsonProperty("playerId")]
        public int PlayerId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}