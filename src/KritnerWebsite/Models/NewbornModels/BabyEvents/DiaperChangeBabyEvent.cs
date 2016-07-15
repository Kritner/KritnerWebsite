using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornModels.BabyEvents
{
    /// <summary>
    /// A diaper change baby event
    /// </summary>
    public class DiaperChangeBabyEvent : BabyEvent
    {
        /// <summary>
        /// Wet diaper?
        /// </summary>
        public bool WetDiaper { get; set; }

        /// <summary>
        /// Dirty diaper?
        /// </summary>
        public bool DirtyDiaper { get; set; }
    }
}
