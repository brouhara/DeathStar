using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    public class PlanetDetailsViewModel
    {
        /// <summary>
        /// The name of this planet.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The average population of sentient beings inhabiting this planet.
        /// </summary>
        [JsonProperty("population")]
        public string Population { get; set; }
        
        /// <summary>
        /// The number of standard hours it takes for this planet to complete a single rotation on it's axis.
        /// </summary>
        [JsonProperty("Rotational_period")]
        public string LengthOfDay { get; set; }
        
        /// <summary>
        /// The number of standard days it takes for this planet to complete a single orbit of it's local star.
        /// </summary>
        [JsonProperty("Orbital_period")]
        public string LengthOfYear { get; set; }

        /// <summary>
        /// The diameter of this planet in kilometers.
        /// </summary>
        [JsonProperty("diameter")]
        public string Diameter { get; set; }

        /// <summary>
        /// The climate of this planet. Comma-seperated if diverse.
        /// </summary>
        [JsonProperty("climate")]
        public string Climate { get; set; }

        /// <summary>
        /// The percentage of the planet surface that is naturally occuring water or bodies of water.
        /// </summary>
        [JsonProperty("surface_water")]
        public string Surface_water { get; set; }

        /// <summary>
        /// A number denoting the gravity of this planet. Where 1 is normal.
        /// </summary>
        [JsonProperty("gravity")]
        public string Gravity { get; set; }

        /// <summary>
        /// the terrain of this planet. Comma-seperated if diverse.
        /// </summary>
        [JsonProperty("terrain")]
        public string Terrain { get; set; }

        /// <summary>
        /// The residents of this planet
        /// </summary>
        [JsonProperty("residents")]
        public List<string> Residents { get; set; }

        /// <summary>
        /// Returns the Diameter as a number
        /// If diameter is unknown returns negative one so that it can be displayed at the bottom of the sort
        /// </summary>
        public long FormattedDiameter => (Diameter == "unknown") ? -1 : long.Parse(Diameter);

        /// <summary>
        /// The average population of sentient beings inhabiting this planet.
        /// </summary>
        public string FormattedPopulation => Population == "unknown" ? "unknown" : long.Parse(Population).ToString("N0");
    }
}