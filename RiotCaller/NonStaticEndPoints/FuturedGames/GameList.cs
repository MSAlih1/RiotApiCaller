﻿using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.FuturedGames
{
    public class GameList
    {
        [JsonProperty("gameLength")]
        public int GameLength { get; set; }

        [JsonProperty("gameMode")]
        public gameMode GameMode { get; set; }

        [JsonProperty("mapId")]
        public mapType MapId { get; set; }

        [JsonProperty("bannedChampions")]
        public List<BannedChampion> BannedChampions { get; set; }

        [JsonProperty("gameType")]
        public gameType? GameType { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("observers")]
        public Observers Observers { get; set; }

        [JsonProperty("gameQueueConfigId")]
        public queue GameQueueConfigId { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("gameStartTime")]
        public DateTime GameStartTime { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("platformId")]
        public Platform PlatformId { get; set; }
    }
}