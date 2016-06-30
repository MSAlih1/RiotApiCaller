using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{

    public class Mastery
    {

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }
    }
}
