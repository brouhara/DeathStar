using PlattSampleApp.Data_Access_Layer;
using PlattSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Business_Logic_Layer
{
    /// <summary>
    /// Provides functions for accessing vehicle information.
    /// </summary>
    public class VehiclesLogic
    {
        VehiclesDAC vehiclesAPI = new VehiclesDAC();

        /// <summary>
        /// Creates a summary view of all manufacturers vehicles
        /// </summary>
        /// <returns>View of all the vehicles</returns>
        public VehicleSummaryViewModel GetAllVehicles()
        {
            // Create our vehicle Summary
            var vehicleSummary = new VehicleSummaryViewModel();

            // Get our list of vehicles
            var vehicles = vehiclesAPI.GetAllVehicles();

            // Get the total number of vehicles where the cost is unknnown
            vehicleSummary.VehicleCount = vehicles.Vehicles
                .Where(vehicle => vehicle.Cost_in_credits == "unknown")
                .Count();

            // Group the known cost models by manufacturer
            var vehiclesByManufacturer = vehicles.Vehicles
                .Where(vehicle => vehicle.Cost_in_credits != "unknown")
                .GroupBy(vehicle => vehicle.manufacturer).ToList();

            // Get the number of Manufacturers
            vehicleSummary.ManufacturerCount = vehiclesByManufacturer.Count();

            // Add each manufacturers vehicle summary to the view
            vehiclesByManufacturer.ToList().ForEach(manufacturer =>
            {
                // Create a new model for each manufacturer
                var vehicleStatsSummary = new VehicleStatsViewModel();

                // Set the manufacturer name
                vehicleStatsSummary.ManufacturerName = manufacturer.Key;

                // Set the number of vehicles
                vehicleStatsSummary.VehicleCount = manufacturer.Count();

                // Get the vehicles that the cost is known
                var vehiclesWithCost = manufacturer;

                // Set the average cost
                vehicleStatsSummary.AverageCost = vehiclesWithCost.Average(vehicle => long.Parse(vehicle.Cost_in_credits));

                // Add the manufacturer summary
                vehicleSummary.Details.Add(vehicleStatsSummary);

            });

            // Sort the results
            vehicleSummary.Details = vehicleSummary.Details
                .OrderByDescending(manufacturer => manufacturer.VehicleCount)
                .ThenByDescending(manufacturer => manufacturer.AverageCost)
                .ToList();
            
            return vehicleSummary;
        }


    }
}