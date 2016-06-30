using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{
    public class Rune
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("runeId")]
        public int RuneId { get; set; }
    }
}
