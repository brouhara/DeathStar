using System.Web.Mvc;
using PlattSampleApp.Models;

// Import the Json Serializer
using System.Net.Http;
using PlattSampleApp.Business_Logic_Layer;

namespace PlattSampleApp.Controllers
{
    public class HomeController : Controller
    {

        private PlanetsLogic planets = new PlanetsLogic();
        private PlanetResidentsLogic people = new PlanetResidentsLogic();
        private VehiclesLogic vehicles = new VehiclesLogic();

        static HttpClient client = new HttpClient();

        public ActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// Displays a view of all the planets in the Star Wars Universe.
        /// </summary>
        /// <returns>View of all the planets in the Star Wars Universe</returns>
        public ActionResult GetAllPlanets()
        {
            var model = planets.GetAllPlanets();

            return View(model);
        }

        /// <summary>
        /// Display a view of plenty twenty two
        /// </summary>
        /// <param name="planetId">ID of the planet to view</param>
        /// <returns>View of the planet specified</returns>
        public ActionResult GetPlanetTwentyTwo(int planetId)
        {
            var model = planets.GetPlanet(planetId);

            return View(model);

        }

        /// <summary>
        /// Returns a view of the residents of a planet
        /// </summary>
        /// <param name="planetname">Name of the planet to retrieve</param>
        /// <returns>View of the Model for the planet</returns>
        public ActionResult GetResidentsOfPlanetNaboo(string planetName)
        {
            var model = people.GetAllPlanetResidents(planetName);
            
            return View(model);
        }

        /// <summary>
        /// Returns a summary view of the manufacturers vehicles
        /// </summary>
        /// <returns>Summary view of the manufacturers vehicles</returns>
        public ActionResult VehicleSummary()
        {
            var model = vehicles.GetAllVehicles();

            // TODO: Implement this controller action

            return View(model);
        }
    }
}