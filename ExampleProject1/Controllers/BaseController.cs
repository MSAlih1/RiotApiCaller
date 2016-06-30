using ExampleProject1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleProject1.Controllers
{
    public class BaseController : Controller
    {
        public ILolApi LolApi  { get; private set; }

        public BaseController(ILolApi _lolapi)
        {
            LolApi = _lolapi;
        }
    }
}