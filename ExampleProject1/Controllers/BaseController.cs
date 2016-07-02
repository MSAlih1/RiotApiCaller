using RiotCaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleProject2.Controllers
{
    public class BaseController : Controller
    {
        public IApiService LolService  { get; private set; }

        public BaseController(IApiService _lolapi)
        {
            LolService = _lolapi;
        }
    }
}