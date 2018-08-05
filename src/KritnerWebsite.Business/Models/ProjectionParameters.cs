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
            int percentIncreasePerYear
        )
        {
            OriginalYearlyUsage = originalYearlyUsage;
            YearsToProject = yearsToProject;
            PercentIncreasePerYear = percentIncreasePerYear;
        }

        public YearlyElectricityUsage OriginalYearlyUsage { get; }
        public int YearsToProject { get; }
        public int PercentIncreasePerYear { get; }
    }
}
