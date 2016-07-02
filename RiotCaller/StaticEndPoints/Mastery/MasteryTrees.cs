using System.Collections.Generic;

namespace RiotCaller.StaticEndPoints.Mastery
{
    public class MasteryTrees
    {
        public List<MasteryTreeList> Offense { get; set; }

        public List<MasteryTreeList> Utility { get; set; }

        public List<MasteryTreeList> Defense { get; set; }
    }
}