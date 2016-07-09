using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornInputOutputModels.BabyEvents
{
    /// <summary>
    /// Breast feeding baby event
    /// </summary>
    public class BreastFeedingBabyEvent : BabyEvent
    {
        /// <summary>
        /// The breast the feeding session began with
        /// </summary>
        public Breast StartingBreast { get; set; }

        /// <summary>
        /// The duration in minutes of the feeding session
        /// </summary>
        public int FeedingDurationInMinutes { get; set; }
    }

    /// <summary>
    /// Breast enum
    /// </summary>
    public enum Breast
    {
        Left = 0,
        Right = 1
    }
}
