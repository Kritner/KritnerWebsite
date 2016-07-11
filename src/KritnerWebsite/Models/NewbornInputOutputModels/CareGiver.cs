using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornInputOutputModels
{
    /// <summary>
    /// A caregiver to a baby
    /// </summary>
    public class CareGiver : Person
    {
        /// <summary>
        /// The application user information
        /// </summary>
        [Required]
        public ApplicationUser User { get; set; }

        /// <summary>
        /// The baby events the CareGiver has administered
        /// </summary>
        public virtual ICollection<BabyEvent> BabyEvents { get; set; }
    }
}
