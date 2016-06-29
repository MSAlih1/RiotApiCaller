using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.Classes.Summoner
{
    public class Summoner
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public DateTime RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
