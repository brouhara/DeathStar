using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    public class ResidentSummary
    {

        /// <summary>
        /// The url of the planet resource that this person was born on.
        /// </summary>
        [JsonProperty("homeworld")]
        public string Homeworld { get; set; }

        /// <summary>
        /// The name of this person.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The eye color of this person.
        /// </summary>
        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        /// <summary>
        /// The hair color of this person.
        /// </summary>
        [JsonProperty("hair_color")]
        public string HairColor { get; set; }

        /// <summary>
        /// The skin color of this person.
        /// </summary>
        [JsonProperty("skin_color")]
        public string SkinColor { get; set; }

        /// <summary>
        /// The gender of this person (if known).
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// The height of this person in meters.
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// The mass of this person in kilograms.
        /// </summary>
        [JsonProperty("mass")]
        public string Weight { get; set; }

        /// <summary>
        /// An array of vehicle resources that this person has piloted
        /// </summary>
        [JsonProperty("vehicles")]
        public List<string> Vehicles { get; set; }

        /// <summary>
        /// The url of this resource
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// An array of starship resources that this person has piloted
        /// </summary>
        [JsonProperty("starships")]
        public List<string> Starships { get; set; }

        /// <summary>
        /// An array of urls of film resources that this person has been in.
        /// </summary>
        [JsonProperty("films")]
        public List<string> Films { get; set; }

        /// <summary>
        /// The birth year of this person. BBY (Before the Battle of Yavin) or ABY (After the Battle of Yavin).
        /// </summary>
        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        /// <summary>
        /// The url of the species resource that this person is.
        /// </summary>
        [JsonProperty("species")]
        public List<string> Species { get; set; }
        
    }
}