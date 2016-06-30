using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Team
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
}
