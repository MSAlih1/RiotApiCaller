using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class MasteryTreeList
    {
        [JsonProperty("masteryTreeItems")]
        public List<MasteryTreeListItem> MasteryTreeItems { get; set; }
    }
}