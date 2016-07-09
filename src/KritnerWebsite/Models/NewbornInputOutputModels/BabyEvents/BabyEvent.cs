using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornInputOutputModels
{
    /// <summary>
    /// Abstract class for baby events
    /// </summary>
    public abstract class BabyEvent
    {
        /// <summary>
        /// The event unique identifier
        /// </summary>
        [Key]
        public int EventId { get; set; }

        /// <summary>
        /// The baby the event pertains too
        /// </summary>
        [Required]
        public int BabyId { get; set; }

        /// <summary>
        /// The caregiver submitting the event
        /// </summary>
        [Required]
        public int CareGiverId { get; set; }

        /// <summary>
        /// The event time
        /// </summary>
        public DateTime EventTime { get; set; }


        /// <summary>
        /// Additional notes pertaining to baby event.
        /// </summary>
        public string Notes { get; set; }
    }
}
