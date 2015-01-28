using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MDVApi.Queries;
using MDVApi.Results;
using Microsoft.Ajax.Utilities;

namespace JourneyPlannerDemo.Models
{
    public class JourneyPlanner
    {
        public  JourneyQuery Query { get; set; }

        public JourneyResults Results { get; set; }

    }
}