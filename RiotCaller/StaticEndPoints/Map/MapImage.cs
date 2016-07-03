﻿using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Map
{
    public class MapImage
    {
        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("w")]
        public int W { get; set; }
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }
}