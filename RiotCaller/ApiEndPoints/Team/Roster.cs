using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.ApiEndPoints.Team
{
    public class Roster
    {
        [JsonProperty("memberList")]
        public List<MemberList> MemberList { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }
    }
}
