using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.SolarProjection.Helpers
{
    public static class FormulaHelpers
    {
        /// <summary>
        /// Compound interest formula
        /// </summary>
        /// <remarks>https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php</remarks>
        /// <param name="principal">The original balance</param>
        /// <param name="interestRate">The interest rate (.55 is 55%)</param>
        /// <param name="compoundsPerYear">Number of times the interest is compounded in a year</param>
        /// <param name="timeInYears">Time in years to calculate interest on</param>
        /// <returns></returns>
        public static double CompoundInterest(
            double principal, 
            double interestRate, 
            int compoundsPerYear, 
            int timeInYears
        )
        {
            return principal * Math.Pow(1 + (interestRate / compoundsPerYear), compoundsPerYear * timeInYears);
        }
    }
}
