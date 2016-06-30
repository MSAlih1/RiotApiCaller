using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{

    public class ParticipantIdentity
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
    }
}
