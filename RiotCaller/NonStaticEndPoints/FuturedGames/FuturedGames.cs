using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.FuturedGames
{
    public class FuturedGames
    {
        [JsonProperty("clientRefreshInterval")]
        public int ClientRefreshInterval { get; set; }

        [JsonProperty("gameList")]
        public List<GameList> GameList { get; set; }
    }
}
