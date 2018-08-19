using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class ProjectionParameters
    {
        public ProjectionParameters(
            YearlyKwhUsageFromMonthly originalYearlyUsage,
            int yearsToProject,
            double percentIncreasePerYear
        )
        {
            OriginalYearlyUsage = originalYearlyUsage;
            YearsToProject = yearsToProject;
            PercentIncreasePerYear = percentIncreasePerYear;
        }

        public IYearlyKwhUsage OriginalYearlyUsage { get; }
        public int YearsToProject { get; }
        public double PercentIncreasePerYear { get; }
    }
}
