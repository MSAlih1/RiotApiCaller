using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.ApiEndPoints.Match
{

    public class MatchDetailTimeline
    {

        [JsonProperty("frameInterval")]
        public int FrameInterval { get; set; }

        [JsonProperty("frames")]
        public List<Frame> Frames { get; set; }
    }
}
