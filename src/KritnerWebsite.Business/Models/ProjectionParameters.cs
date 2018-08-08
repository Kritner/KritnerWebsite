using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class ProjectionParameters
    {
        public ProjectionParameters(
            YearlyElectricityUsage originalYearlyUsage,
            int yearsToProject,
            double percentIncreasePerYear
        )
        {
            OriginalYearlyUsage = originalYearlyUsage;
            YearsToProject = yearsToProject;
            PercentIncreasePerYear = percentIncreasePerYear;
        }

        public YearlyElectricityUsage OriginalYearlyUsage { get; }
        public int YearsToProject { get; }
        public double PercentIncreasePerYear { get; }
    }
}
