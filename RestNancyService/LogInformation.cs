using System;
using System.Collections.Generic;

namespace RestNancyService
{
    public class LogInformation
    {     
        public string Status { get; set; }

        public List<Data> relatedIncident { get; set; }

        public string LogClass { get; set; }

        public string ISO_DATE { get; set; }
        
        public string ORGMSG { get; set; }
    }

    public class Data
    {
        public string status { get; set; }

        public string causeAnalysis { get; set; }

        public string incidentId { get; set; }

        public string errorLog { get; set; }

        public string solution { get; set; }        
    }
}
