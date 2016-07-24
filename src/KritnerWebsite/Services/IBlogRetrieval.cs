using System.Collections.Generic;
using KritnerWebsite.Models.HomeViewModels;
using KritnerWebsite.Models.HomeModels;
using System.Threading.Tasks;

namespace KritnerWebsite.Services
{
    public interface IBlogRetrieval
    {
        Task<IEnumerable<BlogEntry>> GetBlogEntries(string blogUrl);
    }
}