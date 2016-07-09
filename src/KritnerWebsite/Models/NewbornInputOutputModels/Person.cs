using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornInputOutputModels
{
    /// <summary>
    /// Represents a person
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// The person unique identifier
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The person's first name
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The person's last name
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// The person's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The person's address
        /// </summary>
        [Required]
        public Address Address { get; set; }


        /// <summary>
        /// Notes on the person
        /// </summary>
        public string Notes { get; set; }
    }
}
