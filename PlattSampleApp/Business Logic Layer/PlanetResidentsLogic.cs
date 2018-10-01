using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlattSampleApp.Data_Access_Layer;
using PlattSampleApp.Models;

namespace PlattSampleApp.Business_Logic_Layer
{
    /// <summary>
    /// Provides functions for retrieving information about people in the Star Wars Universe
    /// </summary>
    public class PlanetResidentsLogic
    {
        
        private PeopleDAC peopleAPI = new PeopleDAC();
        private PlanetsDAC planetsAPI = new PlanetsDAC();
        
        /// <summary>
        /// Gets a view of all the residents of a particular planet
        /// </summary>
        /// <param name="planetName">Name of the planet to get residents</param>
        /// <returns>View of the residents of a planet</returns>
        public PlanetResidentsViewModel GetAllPlanetResidents(string planetName)
        {
            // Search for a matching planet, then take the first match
            var planet = planetsAPI
                .GetPlanet(planetName)
                .Planets
                .FirstOrDefault();

            // Create a view model for Planet Residents
            var planetResidents = new PlanetResidentsViewModel
            {
                Count = planet.Residents.Count
            };

            // Query for and add each resident
            planet.Residents.ForEach(resident =>
            {
                planetResidents.Residents.Add(peopleAPI.GetResidentSummary(resident));
            });

            // Sort the residents alphabetically
            planetResidents.Residents = planetResidents.Residents
                .OrderBy(resident => resident.Name)
                .ToList();

            return planetResidents;
        }


    }
}