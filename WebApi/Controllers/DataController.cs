using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DataController : ApiController
    {
        public string Get()
        {
            return "Welcome to web api";
        }
        public List<string>Get(string id)
        {
            return new List<string>
            {
                "New Data1",
                "New Data2"
            };
        }
    }
}
