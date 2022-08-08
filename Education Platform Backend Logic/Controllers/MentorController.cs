using Business_Logic_Layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Education_Platform_Backend_Logic.Controllers
{
    public class MentorController : ApiController
    {
        [Route("api/mentorlist")]
        public HttpResponseMessage Get()
        {
            var data =MentorService.GetAllMentor();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

    }
}
