using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    /// <summary>
    /// Displays details about a single planet
    /// </summary>
    public class SinglePlanetViewModel
    {
        /// <summary>
        /// Name of the planet
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Length in hours of the day
        /// </summary>
        [JsonProperty("rotation_period")]
        public string LengthOfDay { get; set; }

        /// <summary>
        /// Length in days of the years on the planet
        /// </summary>
        [JsonProperty("orbital_period")]
        public string LengthOfYear { get; set; }

        /// <summary>
        /// Diameter of the planet
        /// </summary>
        [JsonProperty("diameter")]
        public string Diameter { get; set; }

        /// <summary>
        /// Type of climate on the planet
        /// </summary>
        [JsonProperty("climate")]
        public string Climate { get; set; }

        /// <summary>
        /// Strength of the gravity on the planet
        /// </summary>
        [JsonProperty("gravity")]
        public string Gravity { get; set; }

        /// <summary>
        /// Percentage of the planets surface that is water
        /// </summary>
        [JsonProperty("surface_water")]
        public string SurfaceWaterPercentage { get; set; }

        /// <summary>
        /// Total number of people on the planet
        /// </summary>
        [JsonProperty("population")]
        public string Population { get; set; }

        /// <summary>
        /// People who are residents on the planet
        /// </summary>
        [JsonProperty("residents")]
        public List<string> Residents { get; set; }

        /// <summary>
        /// Films the planet has been in
        /// </summary>
        [JsonProperty("films")]
        public List<string> Films { get; set;  }

        /// <summary>
        /// Url of the planet
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

    }
}