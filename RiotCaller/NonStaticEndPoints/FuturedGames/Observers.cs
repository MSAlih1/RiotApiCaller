using Newtonsoft.Json;

namespace RiotCaller.EndPoints.FuturedGames
{
    public class Observers
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }
}