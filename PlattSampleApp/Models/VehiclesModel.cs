using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    /// <summary>
    /// Used for parsing the json results of a generic vehicles query
    /// </summary>
    public class VehiclesModel
    {

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
        /// List of all vehicles and their details
        /// </summary>
        [JsonProperty("results")]
        public List<VehicleModel> Vehicles { get; set; }
    }
}