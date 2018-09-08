using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Web.Models
{
    /// <summary>
    /// Parameters for creating a solar projection
    /// </summary>
    public class SolarProjectionParameters
    {
        /// <summary>
        /// The number of years to project
        /// </summary>
        public int YearsToProject { get; set; }

        /// <summary>
        /// The total kw/h year used (will make solar projection with the
        /// assumption the array can theoretically cover 100% of energy needs)
        /// </summary>
        public int UtilitySolarArrayKwhYear { get; set; }

        /// <summary>
        /// The cost per month of the solar financing
        /// </summary>
        public double SolarCostPerMonth { get; set; }

        /// <summary>
        /// The number of years the solar panels are financed
        /// </summary>
        public int SolarFinanceYears { get; set; }

        /// <summary>
        /// The total cost of a utility year
        /// </summary>
        public double UtilityCostFullYear { get; set; }

        /// <summary>
        /// The percentage increase of utility costs per year
        /// </summary>
        public double UtilityPercentIncreasePerYear { get; set; }
    }
}
