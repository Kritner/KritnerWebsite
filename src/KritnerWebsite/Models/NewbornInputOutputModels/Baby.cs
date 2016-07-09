using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornInputOutputModels
{
    /// <summary>
    /// Describes a baby - can have multiple guardians and multiple care givers
    /// </summary>
    public class Baby : Person
    {
        /// <summary>
        /// The baby's guardians
        /// </summary>
        public virtual ICollection<CareGiver> Guardians { get; set; }

        /// <summary>
        /// The baby's caregivers
        /// </summary>
        public virtual ICollection<CareGiver> CareGivers { get; set; }

        /// <summary>
        /// Events related to baby
        /// </summary>
        public virtual ICollection<BabyEvent> BabyEvents { get; set; }
    }
}
