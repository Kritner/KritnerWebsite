using KritnerWebsite.Data;
using KritnerWebsite.Interfaces;
using KritnerWebsite.Models.NewbornModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Repositories
{
    public class CareGiverRepository : ICareGiverRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CareGiverRepository> _logger;

        public CareGiverRepository(ApplicationDbContext context, ILogger<CareGiverRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Gets a user's information
        /// </summary>
        /// <param name="userName">The user name to get information for</param>
        /// <returns>True/false</returns>
        public CareGiver GetUserInformation(string userName)
        {
            return _context
                .CareGivers
                .FirstOrDefault(x => x.UserName.ToUpper() == userName.ToUpper());
        }

        public void CreateCareGiver(CareGiver careGiver)
        {
            _context.CareGivers.Add(careGiver);
            _context.SaveChanges();
        }

        public void UpdateCareGiver(CareGiver careGiver)
        {
            _context.CareGivers.Attach(careGiver);
            var entry = _context.Entry(careGiver).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
