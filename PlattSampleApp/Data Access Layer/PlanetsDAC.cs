using Newtonsoft.Json;
using PlattSampleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace PlattSampleApp.Data_Access_Layer
{
    /// <summary>
    /// Provides Functions for calling the Star Wars API and retrieving information about Planets.
    /// </summary>
    public class PlanetsDAC
    {

        WebRequestDAC request = new WebRequestDAC();

        /// <summary>
        /// Gets a single planet by ID
        /// </summary>
        /// <param name="planetId">ID of the planet</param>
        /// <returns>View of the planet</returns>
        public SinglePlanetViewModel GetPlanet(int planetId)
        {

            string content = request.GetResponse($"https://swapi.co/api/planets/{planetId}/");
            
            return JsonConvert.DeserializeObject<SinglePlanetViewModel>(content);

        }

        /// <summary>
        /// Searches for a planet by name
        /// </summary>
        /// <param name="planetName">Planet name to search for</param>
        /// <returns>View of all the matching planets</returns>
        public AllPlanetsViewModel GetPlanet(string planetName)
        {

            string content = request.GetResponse($"https://swapi.co/api/planets/?search={planetName}");

            return JsonConvert.DeserializeObject<AllPlanetsViewModel>(content);

        }
        
        /// <summary>
        /// Gets all the planets in Star Wars Universe.
        /// </summary>
        /// <returns>View of all the planets in the Star Wars Universe</returns>
        public AllPlanetsViewModel GetAllPlanets()
        {
            var model = new AllPlanetsViewModel
            {
                Next = "https://swapi.co/api/planets/"
            };

            while (model.Next != null)
            {

                var result = JsonConvert.DeserializeObject<AllPlanetsViewModel>(request.GetResponse(model.Next));

                // Update the planets object
                model.Count = result.Count;
                model.Next = result.Next;
                model.Planets.AddRange(result.Planets.ToList());

            }

            return model;
        }




    }
}