using System.ComponentModel.DataAnnotations;

namespace KritnerWebsite.Models.NewbornViewModels
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip { get; set; }
    }
}