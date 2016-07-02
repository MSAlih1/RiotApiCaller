using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Match
{
    public class MatchDetailTimeline
    {
        [JsonProperty("frameInterval")]
        public int FrameInterval { get; set; }

        [JsonProperty("frames")]
        public List<Frame> Frames { get; set; }
    }
}