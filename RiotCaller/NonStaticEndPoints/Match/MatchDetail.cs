﻿using Newtonsoft.Json;
using RiotCaller.Converters;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;

namespace RiotCaller.EndPoints.Match
{
    public class MatchDetail
    {
        [JsonProperty("region")]
        public region Region { get; set; }

        [JsonProperty("matchType")]
        public gameType MatchType { get; set; }

        [JsonConverter(typeof(DateTimeFromLong))]
        [JsonProperty("matchCreation")]
        public DateTime MatchCreation { get; set; }

        [JsonProperty("timeline")]
        public MatchDetailTimeline Timeline { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("matchMode")]
        public gameMode MatchMode { get; set; }

        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentity> ParticipantIdentities { get; set; }

        [JsonProperty("matchVersion")]
        public string MatchVersion { get; set; }

        [JsonProperty("teams")]
        public List<MatchDetailTeam> Teams { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("season")]
        public season Season { get; set; }

        [JsonProperty("queueType")]
        public queue QueueType { get; set; }

        [JsonProperty("matchId")]
        public long MatchId { get; set; }

        [JsonProperty("matchDuration")]
        public int MatchDuration { get; set; }
    }
}