using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiotCaller.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RiotCaller.Converters
{
    public class ChampionTagConverter<TEnum> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(List<string>).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            if (token.Values<string>() == null) return null;
            var liste = token.Values<string>();
            return liste.Select(x => (TEnum)Enum.Parse(typeof(TEnum), x)).ToList();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var liste = (value as List<TEnum>).Select(p => p.ToString()).ToList();
            serializer.Serialize(writer, liste);
        }
    }
}