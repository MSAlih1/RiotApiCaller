using Newtonsoft.Json;

namespace RiotCaller.EndPoints.Match
{
    public class Position
    {
        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }
    }
}