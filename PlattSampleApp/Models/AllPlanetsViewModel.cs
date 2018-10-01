using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace PlattSampleApp.Models
{
    public class AllPlanetsViewModel
    {
        /// <summary>
        /// Returns a list of all planet details
        /// </summary>
        public AllPlanetsViewModel()
        {
            Planets = new List<PlanetDetailsViewModel>();
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
        /// The list of Planets that have been retrieved
        /// </summary>
        [JsonProperty("results")]
        public List<PlanetDetailsViewModel> Planets { get; set; }

        /// <summary>
        /// Returns the average diameter of all retrieved planets
        /// </summary>
        public double AverageDiameter => Planets.Average(p => (p.Diameter == "unknown") ? 0 : long.Parse(p.Diameter));

    }
}