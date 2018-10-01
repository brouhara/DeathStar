using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    public class PlanetResidentsViewModel
    {
        /// <summary>
        /// Returns a list of all planet residents
        /// </summary>
        public PlanetResidentsViewModel()
        {
            Residents = new List<ResidentSummary>();
        }

        /// <summary>
        /// The total number of residents to retrieve
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The url of the next page of residents to retrieve
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; set; }

        /// <summary>
        /// The url of the previous page of residents to retrieve
        /// </summary>
        [JsonProperty("previous")]
        public string Previous { get; set; }

        /// <summary>
        /// List of retrieved residents
        /// </summary>
        [JsonProperty("results")]
        public List<ResidentSummary> Residents { get; set; }
    }
}