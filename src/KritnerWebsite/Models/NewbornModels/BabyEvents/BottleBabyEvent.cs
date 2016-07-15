using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornModels.BabyEvents
{
    /// <summary>
    /// A bottle baby event
    /// </summary>
    public class BottleBabyEvent : BabyEvent
    {
        /// <summary>
        /// The food type the baby received
        /// </summary>
        public FoodType FoodType { get; set; }

        /// <summary>
        /// The amount of liquid in the feeding session
        /// </summary>
        public int MillilitersReceived { get; set; }
    }

    /// <summary>
    /// The food type
    /// </summary>
    public enum FoodType
    {
        BreastMilk = 0,
        Formula = 1
    }
}
