using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    /// <summary>
    /// Model for Vehicles
    /// </summary>
    public class VehicleModel
    {

        /// <summary>
        /// An array of People URL Resources that this vehicle has been piloted by.
        /// </summary>
        [JsonProperty("pilots")]
        public List<string> Pilots { get; set; }

        /// <summary>
        /// The maximum length of time that this vehicle can provide consumables for it's entire crew without having to resupply.
        /// </summary>
        [JsonProperty("consumables")]
        public string Consumables { get; set; }

        /// <summary>
        /// The maximum number of kilograms that this vehicle can transport.
        /// </summary>
        [JsonProperty("cargo_capacity")]
        public string Cargo_capacity { get; set; }

        /// <summary>
        /// The name of this vehicle.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The hypermedia URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// the ISO 8601 date format of the time that this resource was created.
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }

        /// <summary>
        /// the ISO 8601 date format of the time that this resource was edited.
        /// </summary>
        [JsonProperty("edited")]
        public string Edited { get; set; }

        /// <summary>
        /// The number of personnel needed to run or pilot this vehicle.
        /// </summary>
        [JsonProperty("crew")]
        public string Crew { get; set; }

        /// <summary>
        /// The maximum speed of this vehicle in atmosphere.
        /// </summary>
        [JsonProperty("max_atmosphering_speed")]
        public string Max_atmosphering_speed { get; set; }

        /// <summary>
        /// The number of non-essential people this vehicle can transport.
        /// </summary>
        [JsonProperty("passengers")]
        public string Passengers { get; set; }

        /// <summary>
        /// The class of this vehicle, such as Wheeled.
        /// </summary>
        [JsonProperty("vehicle_class")]
        public string Vehicle_class { get; set; }

        /// <summary>
        /// The cost of this vehicle new, in galactic credits.
        /// </summary>
        [JsonProperty("cost_in_credits")]
        public string Cost_in_credits { get; set; }

        /// <summary>
        /// The model or official name of this vehicle. Such as All Terrain Attack Transport.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// The model or official name of this vehicle. Such as All Terrain Attack Transport.
        /// </summary>
        [JsonProperty("films")]
        public List<string> films { get; set; }

        /// <summary>
        /// The manufacturer of this vehicle. Comma seperated if more than one.
        /// </summary>
        [JsonProperty("manufacturer")]
        public string manufacturer { get; set; }

        /// <summary>
        /// The length of this vehicle in meters.
        /// </summary>
        [JsonProperty("length")]
        public string length { get; set; }

    }
}