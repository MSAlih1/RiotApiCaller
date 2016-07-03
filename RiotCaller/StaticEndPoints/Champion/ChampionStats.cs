using Newtonsoft.Json;

namespace RiotCaller.StaticEndPoints.Champion
{
    public class ChampionStats
    {
        [JsonProperty("attackrange")]
        public double Attackrange { get; set; }

        [JsonProperty("mpperlevel")]
        public double Mpperlevel { get; set; }

        [JsonProperty("mp")]
        public double Mp { get; set; }

        [JsonProperty("attackdamage")]
        public double Attackdamage { get; set; }

        [JsonProperty("hp")]
        public double Hp { get; set; }

        [JsonProperty("hpperlevel")]
        public double Hpperlevel { get; set; }

        [JsonProperty("attackdamageperlevel")]
        public double Attackdamageperlevel { get; set; }

        [JsonProperty("armor")]
        public double Armor { get; set; }

        [JsonProperty("mpregenperlevel")]
        public double Mpregenperlevel { get; set; }

        [JsonProperty("hpregen")]
        public double Hpregen { get; set; }

        [JsonProperty("critperlevel")]
        public double Critperlevel { get; set; }

        [JsonProperty("spellblockperlevel")]
        public double Spellblockperlevel { get; set; }

        [JsonProperty("mpregen")]
        public double Mpregen { get; set; }

        [JsonProperty("attackspeedperlevel")]
        public double Attackspeedperlevel { get; set; }

        [JsonProperty("spellblock")]
        public double Spellblock { get; set; }

        [JsonProperty("movespeed")]
        public double Movespeed { get; set; }

        [JsonProperty("attackspeedoffset")]
        public double Attackspeedoffset { get; set; }

        [JsonProperty("crit")]
        public double Crit { get; set; }

        [JsonProperty("hpregenperlevel")]
        public double Hpregenperlevel { get; set; }

        [JsonProperty("armorperlevel")]
        public double Armorperlevel { get; set; }
    }
}