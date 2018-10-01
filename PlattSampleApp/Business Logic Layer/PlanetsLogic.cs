using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PlattSampleApp.Data_Access_Layer;
using PlattSampleApp.Models;

namespace PlattSampleApp.Business_Logic_Layer
{
    /// <summary>
    /// Provides functions for retrieving information about planets in the Star Wars Universe
    /// </summary>
    public class PlanetsLogic
    {
        private PlanetsDAC planets = new PlanetsDAC();

        /// <summary>
        /// Gets a view providing the details of a single planet
        /// </summary>
        /// <param name="planetId">ID of the planet to retrieve</param>
        /// <returns>View of the planet</returns>
        public SinglePlanetViewModel GetPlanet(int planetId)
        {
            return planets.GetPlanet(planetId);
        }

        /// <summary>
        /// Gets a view of all the planets in the star wars galaxy
        /// </summary>
        /// <returns>View of all the planets</returns>
        public AllPlanetsViewModel GetAllPlanets()
        {

            // Get the planets
            var planets = this.planets.GetAllPlanets();

            // Sort the planets by diameter descending
            planets.Planets = planets.Planets
                .OrderByDescending(planet => planet.FormattedDiameter)
                .ToList();
            
            return planets;

        }


    }
}