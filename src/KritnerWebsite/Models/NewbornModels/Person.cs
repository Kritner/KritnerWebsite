using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornModels
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
        /// The person's gender
        /// </summary>
        [Required]
        public Gender Gender { get; set; } = Gender.Female;

        /// <summary>
        /// The person's address
        /// </summary>
        [Required]
        public Address Address { get; set; }

        /// <summary>
        /// Date the person was created
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Notes on the person
        /// </summary>
        public string Notes { get; set; }
    }

    /// <summary>
    /// A person's gender
    /// </summary>
    public enum Gender
    {
        Female = 0,
        Male = 1
    }
}
