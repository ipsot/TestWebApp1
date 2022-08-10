using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebApi1.Models;
using System.Web.Http.Cors;

namespace TestWebApi1.Controllers
{
    //[EnableCors (origins: "https://localhost:44321/api/test/getperson",headers:"*",methods:"*")]
    public class TestController : ApiController
    {
        [HttpGet]
        public Person GetPerson()
        {
            return new Person() { Name = "Виктор", Age = 35 };
        }
    }
}
