using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.StaticEndPoints.Item
{
    public class ItemGold
    {
        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("sell")]
        public int Sell { get; set; }

        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }
    }
}
