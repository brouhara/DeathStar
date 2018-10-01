using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    /// <summary>
    /// Provides a summary of a manufacturers vehicles
    /// </summary>
    public class VehicleSummaryViewModel
    {
        /// <summary>
        /// Returns a list of the manufacturers vehicles stats
        /// </summary>
        public VehicleSummaryViewModel()
        {
            Details = new List<VehicleStatsViewModel>();
        }

        /// <summary>
        /// Total Number of Vehicles with Known Cost
        /// </summary>
        public int VehicleCount { get; set; }

        /// <summary>
        /// Total Number of Manufacturers
        /// </summary>
        public int ManufacturerCount { get; set; }
        
        /// <summary>
        /// List of all vehicles and their details
        /// </summary>
        public List<VehicleStatsViewModel> Details { get; set; }

    }
}