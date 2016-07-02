using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class Mastery
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        

        [JsonProperty("name")]
        public string Name { get; set; }

        
        [JsonProperty("description")]
        public List<string> Description { get; set; }

        [JsonProperty("image")]
        public MasteryImage Image { get; set; }


        [JsonProperty("sanitizedDescription")]
        public List<string> SanitizedDescription { get; set; }

        [JsonProperty("prereq")]
        public string prereq { get; set; }


        [JsonProperty("ranks")]
        public int Rank { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
