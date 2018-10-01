using Newtonsoft.Json;
using PlattSampleApp.Data_Access_Layer;
using PlattSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Data_Access_Layer
{
    public class PeopleDAC
    {

        WebRequestDAC request = new WebRequestDAC();

        /// <summary>
        /// Gets a Resident by their url
        /// </summary>
        /// <param name="url">Url to retrieve the resident</param>
        /// <returns>View of the Resident</returns>
        public ResidentSummary GetResidentSummary(string url)
        {

            string content = request.GetResponse(url);

            return JsonConvert.DeserializeObject<ResidentSummary>(content);

        }

    }
}