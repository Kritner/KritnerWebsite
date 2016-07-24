using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KritnerWebsite.Models.HomeModels
{
    public class BlogEntry
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string BlogEntryLink { get; set; }

        public DateTime EntryPostedDate { get; set; }
    }
}
