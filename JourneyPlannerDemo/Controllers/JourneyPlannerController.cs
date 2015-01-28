using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JourneyPlannerDemo.Models;
using MDVApi.Objects.Enums;
using MDVApi.Queries;
using MDVApi.Results;

namespace JourneyPlannerDemo.Controllers
{
    public class JourneyPlannerController : Controller
    {
        //
        // GET: /JourneyPlanner/
        [HttpGet]
        public ActionResult Index()
        {
            var q = new JourneyQuery{JourneyDateTime = DateTime.Now};
            
            var model = new JourneyPlanner { Query = q };

            return this.View(model);
        }
        
        [HttpPost]
        public ActionResult Index(JourneyPlanner q)
        {
            var baseUri = new Uri(@"http://jp.networkwestmidlands.com/centro"); ////For web.config in production
            // var baseURI = new Uri(@"http://86.188.149.5/api");
            // var baseURI = new Uri(@"http://www.travelinesoutheast.org.uk/em");

            var query = new JourneyQuery
            {
                BaseUri = baseUri,
                Origin = q.Query.Origin,
                Destination = q.Query.Destination,
                Via = string.Empty,
                JourneyTimeType = q.Query.JourneyTimeType,
                JourneyDateTime = q.Query.JourneyDateTime
            };

            var results = new JourneyResults(query);

            q.Results = results;

            return View("Results", q);
        }


    }
}
