using KritnerWebsite.Models.NewbornModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornViewModels
{
    public class CareGiverViewModel
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public Gender Gender { get; set; } = Gender.Female;
        [Required]
        public AddressViewModel Address { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public string Notes { get; set; }
    }
}
