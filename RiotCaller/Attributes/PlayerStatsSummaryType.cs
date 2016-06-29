using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiotCaller.ApiEndPoints.Stats;
using System;
using System.Reflection;

namespace RiotCaller.Attributes
{
    public class StatsSummaryType : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(string).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);
            if (token.Value<string>() != null)
                return Enum.Parse(typeof(PlayerStatsSummaryType), token.Value<string>());
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToString());
        }
    }
}