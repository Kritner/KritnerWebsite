using KritnerWebsite.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class ProjectionParameters
    {
        public ProjectionParameters(
            IYearlyKwhUsage utilityYear,
            int yearsToProject,
            double percentIncreasePerYear
        )
        {
            UtilityYear = utilityYear;
            YearsToProject = yearsToProject;
            PercentIncreasePerYear = percentIncreasePerYear;
        }

        public IYearlyKwhUsage UtilityYear { get; }
        public int YearsToProject { get; }
        public double PercentIncreasePerYear { get; }
    }
}
