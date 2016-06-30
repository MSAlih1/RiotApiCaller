using RiotCaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleProject2.Repositories
{
    public class LolApi : ILolApi
    {
        private NonStaticApi _api;
        public NonStaticApi Api { get { return _api; } }

        private StaticApi _staticapi;
        public StaticApi StaticApi { get { return _staticapi; } }

        public LolApi()
        {
            _api = new NonStaticApi();
            _staticapi = new StaticApi();
        }

    }
}