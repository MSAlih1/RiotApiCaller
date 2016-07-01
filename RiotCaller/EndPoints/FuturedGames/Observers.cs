using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotCaller.EndPoints.FuturedGames
{

    public class Observers
    {
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }
    }
}
