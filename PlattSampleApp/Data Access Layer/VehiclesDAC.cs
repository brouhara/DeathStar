using Newtonsoft.Json;
using PlattSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Data_Access_Layer
{
    /// <summary>
    /// Provides functions for accessing vehicle information
    /// </summary>
    public class VehiclesDAC
    {

        WebRequestDAC request = new WebRequestDAC();

        /// <summary>
        /// Returns a view of all of the available vehicles
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public VehiclesModel GetAllVehicles()
        {
            var vehicles = new VehiclesModel
            {
                Next = "https://swapi.co/api/vehicles/",
                Vehicles = new List<VehicleModel>()
            };

            while (vehicles.Next != null)
            {

                var result = JsonConvert.DeserializeObject<VehiclesModel>(request.GetResponse(vehicles.Next));

                // Update the planets object
                vehicles.Count = result.Count;
                vehicles.Next = result.Next;
                vehicles.Vehicles.AddRange(result.Vehicles.ToList());

            }

            return vehicles;

        }

    }
}