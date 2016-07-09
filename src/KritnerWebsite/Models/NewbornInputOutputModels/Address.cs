using System.ComponentModel.DataAnnotations;

namespace KritnerWebsite.Models.NewbornInputOutputModels
{
    /// <summary>
    /// Address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Unique Identifier for address
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The person to which the address belongs
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        [Required]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [Required]
        public string State { get; set; }

        /// <summary>
        /// Zip
        /// </summary>
        [Required]
        public string Zip { get; set; }
    }
}