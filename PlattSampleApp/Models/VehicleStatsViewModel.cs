using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlattSampleApp.Models
{
    /// <summary>
    /// Used to display a list of manufacturers vehicle statistics
    /// </summary>
    public class VehicleStatsViewModel
    {
        /// <summary>
        /// Name of the vehicle manufacturers 
        /// </summary>
        public string ManufacturerName { get; set; }

        /// <summary>
        /// The number of vehicles this manufacturer makes
        /// </summary>
        public int VehicleCount { get; set; }

        /// <summary>
        /// Average cost of the manufacturers vehicles
        /// </summary>
        public double AverageCost { get; set; }
        
    }
}