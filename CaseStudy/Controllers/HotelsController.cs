using CaseStudy.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CaseStudy.Controllers
{
    public class HotelsController : ApiController
    {
     
        //attribute route for returning hotels based on number of stars
        //return all hotels if no stars value specified
        [Route("{hotels}/{stars?}")]
        public HttpResponseMessage GetHotels(int stars)
        {
            List<Hotel> hotels = new List<Hotel>();

            hotels = Helper.HotelHelper();

            if (hotels.Count > 0)
            {
                if (stars == 2|| stars == 3 || stars == 5)
                {
                    hotels = hotels.Where(x => x.Stars == stars).ToList();
                }
                if (hotels.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, hotels);
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK,"No data found");
        }
    }
}
