﻿using Newtonsoft.Json;
using RiotCaller.EndPoints.Match;
using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StaticEndPoints.SummonerSpells;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.FuturedGames
{
    public class Participant
    {
        [JsonProperty("bot")]
        public bool Bot { get; set; }

        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("teamId")]
        public team TeamId { get; set; }

        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }

        [JsonProperty("masteries")]
        public List<Mastery> Masteries { get; set; }

        [JsonProperty("runes")]
        public List<Rune> Runes { get; set; }

        /// <summary>
        /// smarty property
        /// </summary>
        [JsonIgnore]
        public SummonerSpellData Spell1 { get; set; }

        /// <summary>
        /// smarty property
        /// </summary>
        [JsonIgnore]
        public SummonerSpellData Spell2 { get; set; }

        /// <summary>
        /// smarty property
        /// </summary>
        [JsonIgnore]
        public ChampionData Champion { get; set; }

        public override string ToString()
        {
            return SummonerName;
        }
    }
}