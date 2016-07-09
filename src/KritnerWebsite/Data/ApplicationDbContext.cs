using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KritnerWebsite.Models;
using KritnerWebsite.Models.NewbornInputOutputModels;
using KritnerWebsite.Models.NewbornInputOutputModels.BabyEvents;

namespace KritnerWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region BabyEvents
        /// <summary>
        /// Abstract BabyEvent
        /// </summary>
        public DbSet<BabyEvent> BabyEvents { get; set; }

        /// <summary>
        /// Baby Event - Bottle feeding
        /// </summary>
        public DbSet<BottleBabyEvent> BottleBabyEvents { get; set; }

        /// <summary>
        /// Baby Event - Breast feeding
        /// </summary>
        public DbSet<BreastFeedingBabyEvent> BreastFeedingBabyEvents { get; set; }

        /// <summary>
        /// Baby Event - Diaper Change
        /// </summary>
        public DbSet<DiaperChangeBabyEvent> DiaperChangeBabyEvents { get; set; }
        #endregion BabyEvents

        #region Person
        /// <summary>
        /// abstract People
        /// </summary>
        public DbSet<Person> People { get; set; }

        /// <summary>
        /// Caregivers to a baby
        /// </summary>
        public DbSet<CareGiver> CareGivers { get; set; }

        /// <summary>
        /// Babies
        /// </summary>
        public DbSet<Baby> Babies { get; set; }
        #endregion Person

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
