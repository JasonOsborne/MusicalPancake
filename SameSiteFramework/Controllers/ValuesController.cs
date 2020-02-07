using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;

namespace SameSiteFramework.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            CookieHeaderValue idsrvCookie = new CookieHeaderValue
                ("idsrv", $"{Guid.NewGuid()}");
            idsrvCookie.Path = "/";
            idsrvCookie.HttpOnly = true;

            CookieHeaderValue SignOutCookie = new CookieHeaderValue
                ("SignOutMessage", $"{Guid.NewGuid()}");
            SignOutCookie.Path = "/";
            SignOutCookie.HttpOnly = true;

            CookieHeaderValue SignInMessageCookie = new CookieHeaderValue
                ("SignInMessage", $"{Guid.NewGuid()}");
            SignInMessageCookie.Path = "/";
            SignInMessageCookie.HttpOnly = true;

            CookieHeaderValue idsvrCookie = new CookieHeaderValue
                ("idsvr", $"{Guid.NewGuid()}");
            idsvrCookie.Path = "/";
            idsvrCookie.HttpOnly = true;

            CookieHeaderValue KentorCookie = new CookieHeaderValue
                ("Kentor.00asacxva0IGuessThisWillWork", $"{Guid.NewGuid()}");
            KentorCookie.Path = "/";
            KentorCookie.HttpOnly = true;

            CookieHeaderValue idsvrSessionCookie = new CookieHeaderValue
                ("idsvr.session", $"{Guid.NewGuid()}");
            idsvrSessionCookie.Path = "/";

            HttpResponseMessage response = Request.CreateResponse("SamesiteTest Response");

            response.Headers.AddCookies(new CookieHeaderValue[] {
                idsrvCookie,
                SignOutCookie,
                SignInMessageCookie,
                idsvrCookie,
                KentorCookie,
                idsvrSessionCookie
            });
            return response;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
