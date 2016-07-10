using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.NewbornInputOutputModels
{
    public class BabyEvent
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public DateTime EventStart { get; set; }
        public int FeedingDuration { get; set; }
        public Breast StartBreast { get; set; }
        public bool HadWet { get; set; }
        public bool HadStool { get; set; }
    }

    public enum Breast
    {
        Left,
        Right
    }
}
