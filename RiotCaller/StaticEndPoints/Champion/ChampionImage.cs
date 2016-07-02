﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionImage
    {
        [JsonProperty("w")]
        public int W { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }

        [JsonProperty("sprite")]
        public string Sprite { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }
    }
}