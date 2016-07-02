using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.EndPoints.Game
{
    public class RecentGames
    {
        [JsonProperty("games")]
        public List<Game> Games { get; set; }

        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}
