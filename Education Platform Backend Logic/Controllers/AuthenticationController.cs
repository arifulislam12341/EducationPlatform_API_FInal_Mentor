using Business_Logic_Layer.BOs;
using Business_Logic_Layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Education_Platform_Backend_Logic.Controllers
{
    public class AuthenticationController : ApiController
    {
        [Route("api/mentor/login")]
        [HttpPost]
        public HttpResponseMessage Auth(MentorModel user)
        {
            var data = AuthenticationServices.Auth(user);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "user the pro");
        }

        [Route("api/mentor/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AuthenticationServices.Logout(token);
                if (rs)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, "sucessfull");
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "sorryy");
        }
    }
}
