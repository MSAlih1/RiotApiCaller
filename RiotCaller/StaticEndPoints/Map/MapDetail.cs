using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Map
{
    public class MapDetail
    {
        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("image")]
        public MapImage Image { get; set; }

        [JsonProperty("mapName")]
        public string MapName { get; set; }

        public override string ToString()
        {
            return MapName;
        }
    }
}
